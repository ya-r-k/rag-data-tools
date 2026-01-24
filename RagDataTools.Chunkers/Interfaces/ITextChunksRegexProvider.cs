using System.Text.RegularExpressions;

namespace RagDataTools.Chunkers.Interfaces;

public interface ITextChunksRegexProvider
{
    Regex GetForExtractingWordsBeginning();

    Regex GetForExtractingSentencesBeginning();

    Regex GetForExtractingParagraphsBeginning();

    Regex GetMultipleSpacesRegex();
}
