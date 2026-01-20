using Sample.Chunkers.Interfaces;
using System.Text.RegularExpressions;

namespace Sample.Chunkers.Helpers;

public partial class ChunkTypesRegexProvider : IChunkTypesRegexProvider
{
    [GeneratedRegex(@"```\s*(\w*)\s*\n([\s\S]*?)```", RegexOptions.Multiline)]
    public partial Regex GetForRetrievingCodeBlocks();

    [GeneratedRegex(@"`([^`\n]{1}[^`]{1,})\n{1}`", RegexOptions.Multiline)]
    public partial Regex GetUnusualCodeBlockRegex();

    [GeneratedRegex(@"^>.*(?:\n^>.*)*", RegexOptions.Multiline)]
    public partial Regex GetForRetrievingInfoBlockFromMarkdown();

    [GeneratedRegex(@"<(\/?)table[^>]*>", RegexOptions.Multiline)]
    public partial Regex GetForRetrievingHtmlTableTags();

    [GeneratedRegex(@"\[([^\]]*|[^\]]*\[RELATEDCHUNK][^\]]*\[\/RELATEDCHUNK][^\]]*)\]\(([^)]+)\)", RegexOptions.Singleline)]
    public partial Regex GetExternalLinkRegex();

    [GeneratedRegex(@"(#+)\s*(.+)", RegexOptions.Multiline)]
    public partial Regex GetHeadingRegex();

    [GeneratedRegex(@"!\\?\[([^\]]*)\]\(([^)]+)\)", RegexOptions.Singleline)]
    public partial Regex GetImageLinkRegex();

    [GeneratedRegex(@"\[RELATEDCHUNK\]([a-zA-Z\-]+)-(\d+)\[\/RELATEDCHUNK\]", RegexOptions.Multiline)]
    public partial Regex GetChunkLabelRegex();

    [GeneratedRegex(@"(\[RELATEDCHUNK\]\S+\[/RELATEDCHUNK\])\s*", RegexOptions.Multiline)]
    public partial Regex GetChunkLabelWithWhitespacesRegex();
}
