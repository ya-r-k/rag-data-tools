using System.Text.RegularExpressions;

namespace RagDataTools.Chunkers.Interfaces;

public interface ITextChunksRegexProvider
{
    Regex GetForExtractingSentencesBeginning();

    Regex GetMultipleSpacesRegex();
}
