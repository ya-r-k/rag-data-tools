using Sample.Chunkers.Enums;
using Sample.Chunkers.Interfaces;
using Sample.Chunkers.Models;
using System.Text;

namespace Sample.Chunkers.MarkdownExtractors;

public class MarkdownInfoBlockExtractor(IChunkTypesRegexProvider regexProvider) : IMarkdownChunksExtractor
{
    public List<ChunkModel> ExtractSematicChunksFromText(StringBuilder builder, int lastUsedIndex = 0)
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

        return [.. result];
    }
}
