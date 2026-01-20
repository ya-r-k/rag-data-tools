using Sample.Chunkers.Interfaces;
using Sample.Chunkers.Models;
using Sample.Chunkers.Models.Enums;
using System.Text;

namespace Sample.Chunkers.Strategies.MarkdownExtractors;

public class MarkdownImageLinksExtractor(IChunkTypesRegexProvider regexProvider) : MarkdownChunksExtractor, IMarkdownChunksExtractor
{
    public override List<ChunkModel> ExtractChunksFromText(StringBuilder builder, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();
        var matches = regexProvider.GetForRetrievingImageLinkFromMarkdown()
            .Matches(builder.ToString())
            .ToArray();

        foreach (var match in matches)
        {
            result.Add(new ChunkModel
            {
                Index = ++lastUsedIndex,
                RawContent = match.Value,
                ChunkType = ChunkType.ImageLink,
                Data = new Dictionary<string, object>
                {
                    ["url"] = match.Groups[2].Value,
                    ["alterText"] = match.Groups[1].Value,
                },
                RelatedChunksIndexes = []
            });

            builder.Replace(match.Value, string.Format(ChunksConsts.ImageLinkTemplate, lastUsedIndex));
        }

        return ExecuteNextExtractor(builder, result, lastUsedIndex);
    }
}
