using Sample.Chunkers.Enums;
using Sample.Chunkers.Interfaces;
using Sample.Chunkers.Models;
using System.Text;

namespace Sample.Chunkers.MarkdownExtractors;

public class MarkdownExternalLinksExtractor(IChunkTypesRegexProvider regexProvider) : IMarkdownChunksExtractor
{
    public List<ChunkModel> ExtractSematicChunksFromText(StringBuilder builder, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();
        var matches = regexProvider.GetExternalLinkRegex()
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

        return [.. result];
    }
}
