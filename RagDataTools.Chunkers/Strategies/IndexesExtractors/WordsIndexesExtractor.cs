using RagDataTools.Chunkers.Interfaces;

namespace RagDataTools.Chunkers.Strategies.IndexesExtractors;

public class WordsIndexesExtractor(ITextChunksRegexProvider regexProvider) : IPrimitivesIndexesExtractor
{
    public int[] ExtractIndexes(string text)
    {
        /*int wordIndex = 0;
        var sentences = regexProvider.GetForExtractingSentencesBeginning()
            .Split(text);

        foreach (var sentence in sentences)
        {
            indexes.Add(wordIndex);
            wordIndex += sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }*/

        return [.. regexProvider.GetForExtractingWordsBeginning()
            .Matches(text.Trim())
            .Select(x => x.Index)];
    }
}
