using RagDataTools.Chunkers.Interfaces;
using RagDataTools.Chunkers.Models;
using RagDataTools.Chunkers.Models.Enums;
using System.Text;

namespace RagDataTools.Chunkers.Strategies.MarkdownExtractors;

public abstract class MarkdownComplexChunksExtractorBase(IChunkTypesRegexProvider regexProvider) : MarkdownChunksExtractor
{
    private static readonly Dictionary<string, RelationshipType> labelsChunkTypesPairs = new()
    {
        ["Title"] = RelationshipType.StartsWith,
        ["Table"] = RelationshipType.RelatedTable,
        ["Math-Block"] = RelationshipType.RelatedMathBlock,
        ["Code-Block"] = RelationshipType.RelatedCodeBlock,
        ["Info-Block"] = RelationshipType.RelatedInfoBlock,
        ["Image-Link"] = RelationshipType.RelatedImage,
        ["External-Link"] = RelationshipType.AdditionalLink,
    };

    protected readonly IChunkTypesRegexProvider regexProvider = regexProvider;

    public override abstract List<ChunkModel> ExtractChunksFromText(StringBuilder builder, int lastUsedIndex = 0);

    protected Dictionary<RelationshipType, List<int>> ExtractRelatedChunksIndexes(StringBuilder chunkValue)
    {
        var result = new Dictionary<RelationshipType, List<int>>();
        var matches = regexProvider.GetChunkLabelRegex()
            .Matches(chunkValue.ToString())
            .ToArray();

        foreach (var match in matches)
        {
            if (labelsChunkTypesPairs.TryGetValue(match.Groups[1].Value, out var type))
            {
                if (!result.TryGetValue(type, out var value))
                {
                    value = [];
                    result.Add(type, value);
                }

                value.Add(int.Parse(match.Groups[2].Value));
            }

            chunkValue.Replace(match.Value, string.Empty);
        }

        return result;
    }
}
