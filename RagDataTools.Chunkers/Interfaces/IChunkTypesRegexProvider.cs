using System.Text.RegularExpressions;

namespace RagDataTools.Chunkers.Interfaces;

public interface IChunkTypesRegexProvider
{
    Regex GetForRetrievingCodeBlockFromMarkdown();

    Regex GetForRetrievingUnusualCodeBlockFromMarkdown();

    Regex GetForRetrievingInfoBlockFromMarkdown();

    Regex GetForRetrievingHtmlTableTagsFromMarkdown();

    Regex GetForRetrievingExternalLinkFromMarkdown();

    Regex GetForRetrievingHeadingFromMarkdown();

    Regex GetForRetrievingImageLinkFromMarkdown();

    Regex GetChunkLabelRegex();

    Regex GetChunkLabelWithWhitespacesRegex();
}
