namespace RagDataTools.KeywordExtraction;

/// <summary>
/// Options that control keyword extraction.
/// </summary>
public sealed record KeywordExtractionOptions
{
    /// <summary>
    /// Gets the maximum time allowed for one extraction call.
    /// </summary>
    public TimeSpan Timeout { get; init; } = TimeSpan.FromSeconds(30);

    /// <summary>
    /// Gets the maximum number of keywords stored per chunk.
    /// </summary>
    public int MaxKeywordsPerChunk { get; init; } = 5;
}
