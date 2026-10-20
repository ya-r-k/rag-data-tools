using RagDataTools.Chunkers.Models;
using RagDataTools.Ingest;

namespace RagDataTools.Ingest.Extensions;

/// <summary>
/// Convenience entry points for single-document ingest.
/// </summary>
public static class DocumentIngestExtensions
{
    /// <summary>
    /// Ingests a document from disk using the default service.
    /// </summary>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public static Task<ChunkModel[]> IngestAsync(string path, DocumentFormat format, DocumentIngestOptions? options = null, CancellationToken cancellationToken = default)
    {
        return DocumentIngestService.Default.IngestAsync(path, format, options, cancellationToken);
    }

    /// <summary>
    /// Ingests a document from a stream using the default service.
    /// </summary>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public static Task<ChunkModel[]> IngestAsync(Stream source, DocumentFormat format, DocumentIngestOptions? options = null, CancellationToken cancellationToken = default)
    {
        return DocumentIngestService.Default.IngestAsync(source, format, options, cancellationToken);
    }
}
