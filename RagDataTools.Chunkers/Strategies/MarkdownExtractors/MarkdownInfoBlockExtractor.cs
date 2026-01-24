using RagDataTools.Chunkers.Interfaces;
using RagDataTools.Chunkers.Models;
using RagDataTools.Chunkers.Models.Enums;
using System.Text;

namespace RagDataTools.Chunkers.Strategies.MarkdownExtractors;

public class MarkdownInfoBlockExtractor(IChunkTypesRegexProvider regexProvider) : MarkdownChunksExtractor, IMarkdownChunksExtractor
{
    public override List<ChunkModel> ExtractChunksFromText(StringBuilder builder, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();
        var matches = regexProvider.GetForRetrievingInfoBlockFromMarkdown()
            .Matches(builder.ToString())
            .ToArray();

        foreach (var match in matches)
        {
            var infoBlockContent = match.Value.Trim();

            result.Add(new ChunkModel
            {
                Index = ++lastUsedIndex,
                RawContent = infoBlockContent,
                ChunkType = ChunkType.InfoBlock,
                Data = new Dictionary<string, object>()
                {
                    ["content"] = infoBlockContent,
                },
                RelatedChunksIndexes = [],
            });

            builder.Replace(match.Value, string.Format(ChunksConsts.InfoBlockTemplate, lastUsedIndex));
        }

        return ExecuteNextExtractor(builder, result, lastUsedIndex);
    }
}
