using System.Text.RegularExpressions;

namespace Sample.Chunkers.Interfaces;

public interface IChunkTypesRegexProvider
{
    Regex GetForRetrievingCodeBlocks();

    Regex GetUnusualCodeBlockRegex();

    Regex GetForRetrievingInfoBlockFromMarkdown();

    Regex GetForRetrievingHtmlTableTags();

    Regex GetExternalLinkRegex();

    Regex GetHeadingRegex();

    Regex GetImageLinkRegex();

    Regex GetChunkLabelRegex();

    Regex GetChunkLabelWithWhitespacesRegex();
}
