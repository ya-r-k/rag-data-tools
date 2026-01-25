using RagDataTools.Chunkers.Interfaces;
using System.Text.RegularExpressions;

namespace RagDataTools.Chunkers.Infrastructure;

public partial class TextChunksRegexProvider : ITextChunksRegexProvider
{
    [GeneratedRegex(@"(?:(?:- |\*\s*)+)?[\w\*]+", RegexOptions.Multiline)]
    public partial Regex GetForExtractingWordsBeginning();

    [GeneratedRegex(@"(?:^|(?<=(?:[:]\n|\.|!|\?)\s*))(?:- |\*\s*)*\S", RegexOptions.Multiline)]
    public partial Regex GetForExtractingSentencesBeginning();

    [GeneratedRegex(@"(?:^|(?<=\r?\n\s+?))(?:- |\*\s*)*\S", RegexOptions.Multiline)]
    public partial Regex GetForExtractingParagraphsBeginning();

    [GeneratedRegex(@"( |\u00A0){2,}")]
    public partial Regex GetMultipleSpacesRegex();
}
