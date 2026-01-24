using RagDataTools.Chunkers.Interfaces;
using RagDataTools.Chunkers.Models;
using RagDataTools.Chunkers.Models.Enums;
using System.Text;

namespace RagDataTools.Chunkers.Strategies.MarkdownExtractors;

public class MarkdownCodeBlockExtractor(IChunkTypesRegexProvider regexProvider) : MarkdownChunksExtractor, IMarkdownChunksExtractor
{
    public override List<ChunkModel> ExtractChunksFromText(StringBuilder builder, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();
        var matches = regexProvider.GetForRetrievingCodeBlockFromMarkdown()
            .Matches(builder.ToString())
            .ToArray();

        foreach (var match in matches)
        {
            var codeBlockContent = match.Value.Trim();

            var language = match.Groups[1].Value; // Название языка (если указано)
            language = string.IsNullOrEmpty(language) ? "unknown" : language.ToLower();

            result.Add(new ChunkModel
            {
                Index = ++lastUsedIndex,
                RawContent = codeBlockContent,
                ChunkType = ChunkType.CodeBlock,
                Data = new Dictionary<string, object>()
                {
                    ["language"] = language,
                    ["content"] = codeBlockContent,
                },
                RelatedChunksIndexes = [],
            });

            builder.Replace(codeBlockContent, string.Format(ChunksConsts.CodeBlockTemplate, lastUsedIndex));
        }

        return ExecuteNextExtractor(builder, result, lastUsedIndex);
    }
}
