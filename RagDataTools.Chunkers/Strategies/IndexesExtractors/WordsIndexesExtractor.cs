using RagDataTools.Chunkers.Interfaces;

namespace RagDataTools.Chunkers.Strategies.IndexesExtractors;

public class WordsIndexesExtractor(ITextChunksRegexProvider regexProvider) : IPrimitivesIndexesExtractor
{
    public int[] ExtractIndexes(string text)
    {
        return [.. regexProvider.GetForExtractingWordsBeginning()
            .Matches(text.Trim())
            .Select(x => x.Index)];
    }
}
