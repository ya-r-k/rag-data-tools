using System.Text.RegularExpressions;

namespace Sample.Chunkers.Interfaces;

public interface ITextChunksRegexProvider
{
    Regex GetForExtractingSentencesBeginning();

    Regex GetMultipleSpacesRegex();
}
