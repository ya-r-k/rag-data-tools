using Sample.Chunkers.Interfaces;

namespace Sample.Chunkers.Strategies.IndexesExtractors;

public class SentenceIndexesExtractor(ITextChunksRegexProvider regexProvider) : IPrimitivesIndexesExtractor
{
    /// <summary>
    /// Находит индексы начала предложений в массиве слов.
    /// Использует регулярное выражение для определения границ предложений (точка, восклицательный знак, вопросительный знак, двоеточие с переводом строки).
    /// </summary>
    /// <param name="text">Текст для анализа.</param>
    /// <returns>Массив индексов слов, с которых начинаются предложения.</returns>
    public int[] ExtractIndexes(string text)
    {
        var indexes = new List<int>();
        int wordIndex = 0;
        var sentences = regexProvider.GetForExtractingSentencesBeginning()
            .Split(text);

        foreach (var sentence in sentences)
        {
            indexes.Add(wordIndex);
            wordIndex += sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        return [.. indexes];
    }
}
