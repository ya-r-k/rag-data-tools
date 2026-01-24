using RagDataTools.Chunkers.Interfaces;

namespace RagDataTools.Chunkers.Strategies.IndexesExtractors;

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
        return [.. regexProvider.GetForExtractingSentencesBeginning()
            .Matches(text.Trim())
            .Select(x => x.Index)];
    }
}
