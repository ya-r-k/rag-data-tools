using RagDataTools.Chunkers.Extensions;
using RagDataTools.Chunkers.Models;
using RagDataTools.Ingest.Conversion;

namespace RagDataTools.Ingest;

/// <summary>
/// Ingests a single PDF, Word, or HTML document and returns chunks.
/// </summary>
public sealed class DocumentIngestService
{
    private readonly IReadOnlyDictionary<DocumentFormat, IDocumentToMarkdownConverter> converters;

    /// <summary>
    /// Gets the default service instance with built-in converters.
    /// </summary>
    public static DocumentIngestService Default { get; } = new ();

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentIngestService"/> class.
    /// Creates a service with the built-in PDF, Word, and HTML converters.
    /// </summary>
    public DocumentIngestService()
        : this(new IDocumentToMarkdownConverter[] { new PdfDocumentToMarkdownConverter(), new WordDocumentToMarkdownConverter(), new HtmlDocumentToMarkdownConverter() })
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentIngestService"/> class.
    /// Creates a service with custom converters.
    /// </summary>
    public DocumentIngestService(IEnumerable<IDocumentToMarkdownConverter> converters)
    {
        ArgumentNullException.ThrowIfNull(converters);

        var converterList = converters.ToArray();
        if (converterList.Length == 0)
        {
            throw new ArgumentException("At least one document converter must be provided.", nameof(converters));
        }

        var duplicateFormats = converterList
            .GroupBy(converter => converter.Format)
            .Where(group => group.Count() > 1)
            .Select(group => group.Key)
            .ToArray();

        if (duplicateFormats.Length > 0)
        {
            throw new ArgumentException($"Duplicate converters were registered for: {string.Join(", ", duplicateFormats)}.", nameof(converters));
        }

        this.converters = converterList.ToDictionary(converter => converter.Format);
    }

    /// <summary>
    /// Ingests a single document at the provided path.
    /// </summary>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public async Task<ChunkModel[]> IngestAsync(string path, DocumentFormat format, DocumentIngestOptions? options = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(path);

        await using var stream = File.OpenRead(path);
        return await IngestAsync(stream, format, options, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Ingests a single document from the provided stream.
    /// </summary>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public async Task<ChunkModel[]> IngestAsync(Stream source, DocumentFormat format, DocumentIngestOptions? options = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(source);
        options ??= new DocumentIngestOptions();

        ValidateChunkingOptions(options);

        using var buffered = await BufferAsync(source, cancellationToken).ConfigureAwait(false);
        ValidateSize(buffered.Length, format, options);
        var converter = GetConverter(format);

        IReadOnlyList<MarkdownPageSegment> segments;
        try
        {
            segments = await converter.ConvertAsync(buffered, cancellationToken).ConfigureAwait(false);
        }
        catch (OperationCanceledException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new InvalidDataException($"Failed to ingest {format} document.", ex);
        }

        var chunks = new List<ChunkModel>();
        var lastUsedIndex = 0;

        foreach (var segment in segments)
        {
            if (string.IsNullOrWhiteSpace(segment.markdown))
            {
                continue;
            }

            var pageChunks = segment.markdown.ExtractSemanticChunksDeeply(
                options.ChunkWordsCount,
                options.IndexesExtractor,
                options.OverlapPercentage,
                lastUsedIndex);

            if (segment.pageNumber is not null)
            {
                foreach (var chunk in pageChunks)
                {
                    chunk.SetPageNumber(segment.pageNumber);
                }
            }

            chunks.AddRange(pageChunks);

            if (pageChunks.Length > 0)
            {
                lastUsedIndex = pageChunks[^1].Index;
            }
        }

        return [.. chunks];
    }

    private static void ValidateChunkingOptions(DocumentIngestOptions options)
    {
        if (options.ChunkWordsCount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(options), "ChunkWordsCount must be greater than zero.");
        }

        if (options.OverlapPercentage < 0.0 || options.OverlapPercentage > 1.0)
        {
            throw new ArgumentOutOfRangeException(nameof(options), "OverlapPercentage must be between 0.0 and 1.0.");
        }
    }

    private static void ValidateSize(long length, DocumentFormat format, DocumentIngestOptions options)
    {
        var maxBytes = options.GetMaxBytes(format);
        if (length > maxBytes)
        {
            throw new InvalidDataException($"The {format} document exceeds the documented maximum size of {maxBytes} bytes.");
        }
    }

    private IDocumentToMarkdownConverter GetConverter(DocumentFormat format)
    {
        if (converters.TryGetValue(format, out var converter))
        {
            return converter;
        }

        throw new NotSupportedException($"Unsupported document format: {format}.");
    }

    private static async Task<MemoryStream> BufferAsync(Stream source, CancellationToken cancellationToken)
    {
        var buffer = new MemoryStream();
        await source.CopyToAsync(buffer, 81920, cancellationToken).ConfigureAwait(false);
        buffer.Position = 0;
        return buffer;
    }
}
