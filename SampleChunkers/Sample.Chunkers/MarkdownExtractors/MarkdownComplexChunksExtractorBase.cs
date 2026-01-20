using Sample.Chunkers.Enums;
using Sample.Chunkers.Interfaces;
using System.Text;

namespace Sample.Chunkers.MarkdownExtractors;

public class MarkdownComplexChunksExtractorBase(IChunkTypesRegexProvider regexProvider)
{
    private static readonly Dictionary<string, ChunkType> labelsChunkTypesPairs = new()
    {
        ["Title"] = ChunkType.Topic,
        ["Table"] = ChunkType.Table,
        ["Math-Block"] = ChunkType.MathBlock,
        ["Code-Block"] = ChunkType.CodeBlock,
        ["Info-Block"] = ChunkType.InfoBlock,
        ["Image-Link"] = ChunkType.ImageLink,
        ["External-Link"] = ChunkType.AdditionalLink,
    };

    protected readonly IChunkTypesRegexProvider regexProvider = regexProvider;

    protected Dictionary<ChunkType, List<int>> ExtractRelatedChunksIndexes(StringBuilder chunkValue)
    {
        var result = new Dictionary<ChunkType, List<int>>();
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
