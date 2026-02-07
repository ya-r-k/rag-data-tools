using RagDataTools.Chunkers.Interfaces;

namespace RagDataTools.Chunkers.Strategies.IndexesExtractors;

public class ParagraphIndexesExtractor(ITextChunksRegexProvider regexProvider) : IPrimitivesIndexesExtractor
{
    /// <summary>
    /// Находит индексы начала абзацов в массиве слов.
    /// </summary>
    /// <param name="text">Текст для анализа.</param>
    /// <returns>Массив индексов, с которых начинаются абзацы.</returns>
    public int[] ExtractIndexes(string text)
    {
        return [.. regexProvider.GetForExtractingParagraphsBeginning()
            .Matches(text.Trim())
            .Select(x => x.Index)];
    }
}
