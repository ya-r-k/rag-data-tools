using RagDataTools.Chunkers.Models;

namespace RagDataTools.KeywordExtraction;

/// <summary>
/// Default keyword extraction service with timeout enforcement.
/// </summary>
public sealed class KeywordExtractionService : IKeywordExtractor
{
    private readonly IKeywordExtractionBackend backend;

    /// <summary>
    /// Gets the default service instance that uses the built-in heuristic backend.
    /// </summary>
    public static KeywordExtractionService Default { get; } = new ();

    /// <summary>
    /// Initializes a new instance of the <see cref="KeywordExtractionService"/> class.
    /// Creates a service using the built-in heuristic backend.
    /// </summary>
    public KeywordExtractionService()
        : this(new HeuristicKeywordExtractionBackend())
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="KeywordExtractionService"/> class.
    /// Creates a service using the specified backend.
    /// </summary>
    public KeywordExtractionService(IKeywordExtractionBackend backend)
    {
        ArgumentNullException.ThrowIfNull(backend);
        this.backend = backend;
    }

    /// <inheritdoc />
    public async Task<ChunkModel[]> ExtractAsync(ChunkModel[] chunks, KeywordExtractionOptions? options = null, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(chunks);
        options ??= new KeywordExtractionOptions();

        ValidateOptions(options);

        using var timeoutCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        var extractionTask = ExtractInternalAsync(chunks, options, timeoutCts.Token);
        var timeoutTask = Task.Delay(options.Timeout, cancellationToken);
        var completed = await Task.WhenAny(extractionTask, timeoutTask).ConfigureAwait(false);

        if (completed == timeoutTask)
        {
            timeoutCts.Cancel();

            if (cancellationToken.IsCancellationRequested)
            {
                cancellationToken.ThrowIfCancellationRequested();
            }

            throw new TimeoutException($"Keyword extraction timed out after {options.Timeout}.");
        }

        return await extractionTask.ConfigureAwait(false);
    }

    private async Task<ChunkModel[]> ExtractInternalAsync(ChunkModel[] chunks, KeywordExtractionOptions options, CancellationToken cancellationToken)
    {
        for (var i = 0; i < chunks.Length; i++)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var keywords = await backend.ExtractAsync(chunks[i], options, cancellationToken).ConfigureAwait(false);
            chunks[i].SetKeywords((keywords ?? Array.Empty<string>()).Take(options.MaxKeywordsPerChunk).ToArray());
        }

        return chunks;
    }

    private static void ValidateOptions(KeywordExtractionOptions options)
    {
        if (options.Timeout <= TimeSpan.Zero)
        {
            throw new ArgumentOutOfRangeException(nameof(options.Timeout), "Timeout must be greater than zero.");
        }

        if (options.MaxKeywordsPerChunk <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(options.MaxKeywordsPerChunk), "MaxKeywordsPerChunk must be greater than zero.");
        }
    }
}
