using RagDataTools.Chunkers.Interfaces;

namespace RagDataTools.Chunkers.Strategies.IndexesExtractors;

public class ParagraphIndexesExtractor(ITextChunksRegexProvider regexProvider) : IPrimitivesIndexesExtractor
{
    /// <summary>
    /// Находит индексы начала абзацов в массиве слов.
    /// Параграфы определяются по разделителю "\n " (новая строка с пробелом).
    /// </summary>
    /// <param name="text">Текст для анализа.</param>
    /// <returns>Массив индексов, с которых начинаются абзацы.</returns>
    public int[] ExtractIndexes(string text)
    {
        /*
        int wordIndex = 0;

        var paragraphs = text.Split("\n ", StringSplitOptions.RemoveEmptyEntries);

        foreach (var paragraph in paragraphs)
        {
            indexes.Add(wordIndex);
            wordIndex += paragraph.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
         */

        return [.. regexProvider.GetForExtractingParagraphsBeginning()
            .Matches(text.Trim())
            .Select(x => x.Index)];
    }
}
