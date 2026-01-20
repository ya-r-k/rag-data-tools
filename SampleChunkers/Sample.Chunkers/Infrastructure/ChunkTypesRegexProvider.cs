using Sample.Chunkers.Interfaces;
using System.Text.RegularExpressions;

namespace Sample.Chunkers.Infrastructure;

public partial class ChunkTypesRegexProvider : IChunkTypesRegexProvider
{
    [GeneratedRegex(@"```\s*(\w*)\s*\n([\s\S]*?)```", RegexOptions.Multiline)]
    public partial Regex GetForRetrievingCodeBlockFromMarkdown();

    [GeneratedRegex(@"`([^`\n]{1}[^`]{1,})\n{1}`", RegexOptions.Multiline)]
    public partial Regex GetForRetrievingUnusualCodeBlockFromMarkdown();

    [GeneratedRegex(@"^>.*(?:\n^>.*)*", RegexOptions.Multiline)]
    public partial Regex GetForRetrievingInfoBlockFromMarkdown();

    [GeneratedRegex(@"<(\/?)table[^>]*>", RegexOptions.Multiline)]
    public partial Regex GetForRetrievingHtmlTableTagsFromMarkdown();

    [GeneratedRegex(@"\[([^\]]*|[^\]]*\[RELATEDCHUNK][^\]]*\[\/RELATEDCHUNK][^\]]*)\]\(([^)]+)\)", RegexOptions.Singleline)]
    public partial Regex GetForRetrievingExternalLinkFromMarkdown();

    [GeneratedRegex(@"(#+)\s*(.+)", RegexOptions.Multiline)]
    public partial Regex GetForRetrievingHeadingFromMarkdown();

    [GeneratedRegex(@"!\\?\[([^\]]*)\]\(([^)]+)\)", RegexOptions.Singleline)]
    public partial Regex GetForRetrievingImageLinkFromMarkdown();

    [GeneratedRegex(@"\[RELATEDCHUNK\]([a-zA-Z\-]+)-(\d+)\[\/RELATEDCHUNK\]", RegexOptions.Multiline)]
    public partial Regex GetChunkLabelRegex();

    [GeneratedRegex(@"(\[RELATEDCHUNK\]\S+\[/RELATEDCHUNK\])\s*", RegexOptions.Multiline)]
    public partial Regex GetChunkLabelWithWhitespacesRegex();
}
