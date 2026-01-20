using Sample.Chunkers.Enums;
using Sample.Chunkers.Interfaces;
using Sample.Chunkers.Models;
using System.Text;

namespace Sample.Chunkers.MarkdownExtractors;

public class MarkdownHeadingExtractor(
    IChunkTypesRegexProvider regexProvider) : MarkdownComplexChunksExtractorBase(regexProvider), IMarkdownChunksExtractor
{
    public List<ChunkModel> ExtractSematicChunksFromText(StringBuilder builder, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();
        var matches = regexProvider.GetHeadingRegex()
            .Matches(builder.ToString())
            .ToArray();

        foreach (var match in matches)
        {
            var titleText = new StringBuilder(match.Groups[2].Value.TrimEnd());
            var relatedIndexes = ExtractRelatedChunksIndexes(titleText);

            result.Add(new ChunkModel
            {
                Index = ++lastUsedIndex,
                RawContent = match.Value.TrimEnd(),
                ChunkType = ChunkType.Topic,
                Data = new Dictionary<string, object>
                {
                    ["name"] = titleText.ToString(),
                    ["level"] = match.Groups[1].Length,
                },
                RelatedChunksIndexes = relatedIndexes,
            });

            builder.Replace(match.Value, string.Format(ChunksConsts.HeaderTemplate, lastUsedIndex));
        }

        return [.. result];
    }
}
