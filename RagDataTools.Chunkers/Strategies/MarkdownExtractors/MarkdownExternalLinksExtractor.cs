using RagDataTools.Chunkers.Interfaces;
using RagDataTools.Chunkers.Models;
using RagDataTools.Chunkers.Models.Enums;
using System.Text;

namespace RagDataTools.Chunkers.Strategies.MarkdownExtractors;

public class MarkdownExternalLinksExtractor(IChunkTypesRegexProvider regexProvider) : MarkdownChunksExtractor, IMarkdownChunksExtractor
{
    public override List<ChunkModel> ExtractChunksFromText(StringBuilder builder, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();
        var matches = regexProvider.GetForRetrievingExternalLinkFromMarkdown()
            .Matches(builder.ToString())
            .ToArray();

        foreach (var match in matches)
        {
            var altText = match.Groups[1].Value;
            result.Add(new ChunkModel
            {
                Index = ++lastUsedIndex,
                RawContent = match.Value,
                ChunkType = ChunkType.AdditionalLink,
                Data = new Dictionary<string, object>
                {
                    ["url"] = match.Groups[2].Value,
                    ["alterText"] = altText,
                },
                RelatedChunksIndexes = []
            });

            builder.Replace(match.Value, altText + string.Format(ChunksConsts.ExternalLinkTemplate, lastUsedIndex));
        }

        return ExecuteNextExtractor(builder, result, lastUsedIndex);
    }
}
