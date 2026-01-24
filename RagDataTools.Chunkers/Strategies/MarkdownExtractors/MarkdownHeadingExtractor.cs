using RagDataTools.Chunkers.Interfaces;
using RagDataTools.Chunkers.Models;
using RagDataTools.Chunkers.Models.Enums;
using System.Text;

namespace RagDataTools.Chunkers.Strategies.MarkdownExtractors;

public class MarkdownHeadingExtractor(
    IChunkTypesRegexProvider regexProvider) : MarkdownComplexChunksExtractorBase(regexProvider), IMarkdownChunksExtractor
{
    public override List<ChunkModel> ExtractChunksFromText(StringBuilder builder, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();
        var matches = regexProvider.GetForRetrievingHeadingFromMarkdown()
            .Matches(builder.ToString())
            .ToArray();

        if (matches.Length > 0)
        {
            var titlesPrevIndexes = new Dictionary<int, int>(); // Уровень -> последний индекс

            for (var i = 0; i < matches.Length; i++)
            {
                var match = matches[i];

                var currentLevel = match.Groups[1].Length;
                var titleText = new StringBuilder(match.Groups[2].Value.TrimEnd());
                var relatedIndexes = ExtractRelatedChunksIndexes(titleText);

                titlesPrevIndexes[currentLevel] = i;

                result.Add(new ChunkModel
                {
                    Index = ++lastUsedIndex,
                    RawContent = match.Value.TrimEnd(),
                    ChunkType = ChunkType.Topic,
                    Data = new Dictionary<string, object>
                    {
                        ["name"] = titleText.ToString(),
                        ["level"] = currentLevel,
                    },
                    RelatedChunksIndexes = relatedIndexes,
                });

                builder.Replace(match.Value, string.Format(ChunksConsts.HeaderTemplate, lastUsedIndex));

                if (i >= matches.Length - 1) continue;

                var nextLevel = matches[i + 1].Groups[1].Length;
                var relType = nextLevel > currentLevel
                    ? RelationshipType.HasFirstSubtopic
                    : RelationshipType.HasNextTopic;

                if (nextLevel < currentLevel)
                {
                    if (titlesPrevIndexes.TryGetValue(nextLevel, out int lastSameLevelIndex))
                    {
                        result[lastSameLevelIndex].RelatedChunksIndexes[relType] = [lastUsedIndex + 1];
                    }
                }
                else
                {
                    result[i].RelatedChunksIndexes[relType] = [lastUsedIndex + 1];
                }
            }
        }

        return ExecuteNextExtractor(builder, result, lastUsedIndex);
    }
}
