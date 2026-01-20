using Sample.Chunkers.Enums;
using Sample.Chunkers.Interfaces;
using Sample.Chunkers.Models;
using System.Text;

namespace Sample.Chunkers.MarkdownExtractors;

public class MarkdownUnusualCodeBlockExtractor(IChunkTypesRegexProvider regexProvider) : MarkdownChunksExtractor, IMarkdownChunksExtractor
{
    public override List<ChunkModel> ExtractChunksFromText(StringBuilder builder, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();
        var matches = regexProvider.GetUnusualCodeBlockRegex()
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
