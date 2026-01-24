using RagDataTools.Chunkers.Interfaces;
using RagDataTools.Chunkers.Models;
using RagDataTools.Chunkers.Models.Enums;
using System.Text;

namespace RagDataTools.Chunkers.Strategies.MarkdownExtractors;

public class MarkdownUnusualCodeBlockExtractor(IChunkTypesRegexProvider regexProvider) : MarkdownChunksExtractor, IMarkdownChunksExtractor
{
    public override List<ChunkModel> ExtractChunksFromText(StringBuilder builder, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();
        var matches = regexProvider.GetForRetrievingUnusualCodeBlockFromMarkdown()
            .Matches(builder.ToString())
            .ToArray();

        foreach (var match in matches)
        {
            var codeBlockContent = match.Value.Trim();

            result.Add(new ChunkModel
            {
                Index = ++lastUsedIndex,
                RawContent = codeBlockContent,
                ChunkType = ChunkType.CodeBlock,
                Data = new Dictionary<string, object>()
                {
                    ["language"] = "unknown",
                    ["content"] = codeBlockContent,
                },
                RelatedChunksIndexes = [],
            });

            builder.Replace(codeBlockContent, string.Format(ChunksConsts.CodeBlockTemplate, lastUsedIndex));
        }

        return ExecuteNextExtractor(builder, result, lastUsedIndex);
    }
}
