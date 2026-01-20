using Sample.Chunkers.Enums;
using Sample.Chunkers.Interfaces;
using Sample.Chunkers.Models;
using System.Text;
using System.Text.RegularExpressions;

namespace Sample.Chunkers.MarkdownExtractors;

public class MarkdownHtmlTableExtractor(IChunkTypesRegexProvider regexProvider) : MarkdownChunksExtractor, IMarkdownChunksExtractor
{
    public override List<ChunkModel> ExtractChunksFromText(StringBuilder builder, int lastUsedIndex = 0)
    {
        var rawText = builder.ToString();
        var result = new List<ChunkModel>();
        var tagsMatches = regexProvider.GetForRetrievingHtmlTableTags()
            .Matches(rawText)
            .ToArray();
        var depth = 0;
        var startIndex = -1;

        foreach (Match tagMatch in tagsMatches)
        {
            var isClosing = tagMatch.Groups[1].Value.Length != 0;

            if (!isClosing)
            {
                if (depth == 0)
                {
                    startIndex = tagMatch.Index;
                }

                depth++;
            }
            else
            {
                depth--;

                if (depth == 0 && startIndex >= 0)
                {
                    var endIndex = tagMatch.Index + tagMatch.Length;
                    var tableBlockContent = rawText[startIndex..endIndex];

                    result.Add(new ChunkModel
                    {
                        Index = ++lastUsedIndex,
                        RawContent = tableBlockContent,
                        ChunkType = ChunkType.Table,
                        Data = new Dictionary<string, object>
                        {
                            ["content"] = tableBlockContent,
                        },
                        RelatedChunksIndexes = []
                    });
                    builder.Replace(tableBlockContent, string.Format(ChunksConsts.TableTemplate, lastUsedIndex));

                    startIndex = -1;
                }
            }
        }

        return ExecuteNextExtractor(builder, result, lastUsedIndex);
    }
}
