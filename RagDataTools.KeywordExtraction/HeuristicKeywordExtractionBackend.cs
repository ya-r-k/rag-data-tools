using System.Text.RegularExpressions;
using RagDataTools.Chunkers.Models;

namespace RagDataTools.KeywordExtraction;

/// <summary>
/// Deterministic keyword backend used when no external service is configured.
/// </summary>
public sealed class HeuristicKeywordExtractionBackend : IKeywordExtractionBackend
{
    private static readonly Regex TokenRegex = new (@"[\p{L}\p{N}][\p{L}\p{N}\p{Mn}'-]*", RegexOptions.Compiled | RegexOptions.CultureInvariant);
    private static readonly HashSet<string> StopWords = new (StringComparer.OrdinalIgnoreCase)
    {
        "a", "an", "and", "are", "as", "at", "be", "been", "but", "by", "for", "from", "has",
        "have", "he", "her", "hers", "him", "his", "i", "if", "in", "into", "is", "it", "its",
        "me", "my", "of", "on", "or", "our", "ours", "she", "so", "than", "that", "the", "their",
        "them", "there", "these", "they", "this", "those", "to", "was", "we", "were", "with", "you",
        "your", "yours",
    };

    /// <inheritdoc />
    public Task<string[]> ExtractAsync(ChunkModel chunk, KeywordExtractionOptions options, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(chunk);
        ArgumentNullException.ThrowIfNull(options);
        cancellationToken.ThrowIfCancellationRequested();

        if (string.IsNullOrWhiteSpace(chunk.RawContent))
        {
            return Task.FromResult(Array.Empty<string>());
        }

        var keywords = TokenRegex.Matches(chunk.RawContent)
            .Select(match => match.Value.Trim())
            .Where(token => token.Length > 1)
            .Where(token => !StopWords.Contains(token))
            .GroupBy(token => token, StringComparer.OrdinalIgnoreCase)
            .Select(group => new
            {
                Keyword = group.Key.ToLowerInvariant(),
                Count = group.Count(),
                FirstIndex = group.Min(token => chunk.RawContent.IndexOf(token, StringComparison.OrdinalIgnoreCase)),
            })
            .OrderByDescending(item => item.Count)
            .ThenBy(item => item.FirstIndex)
            .Select(item => item.Keyword)
            .Take(options.MaxKeywordsPerChunk)
            .ToArray();

        return Task.FromResult(keywords);
    }
}
