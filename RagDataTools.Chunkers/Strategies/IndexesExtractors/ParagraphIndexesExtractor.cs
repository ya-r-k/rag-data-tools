namespace RagDataTools.Chunkers.Strategies.IndexesExtractors;

public class ParagraphIndexesExtractor : IPrimitivesIndexesExtractor
{
    /// <summary>
    /// Находит индексы начала параграфов в массиве слов.
    /// Параграфы определяются по разделителю "\n " (новая строка с пробелом).
    /// </summary>
    /// <param name="text">Текст для анализа.</param>
    /// <returns>Массив индексов слов, с которых начинаются параграфы.</returns>
    public int[] ExtractIndexes(string text)
    {
        var indexes = new List<int>();
        int wordIndex = 0;

        var paragraphs = text.Split("\n ", StringSplitOptions.RemoveEmptyEntries);

        foreach (var paragraph in paragraphs)
        {
            indexes.Add(wordIndex);
            wordIndex += paragraph.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        return [.. indexes];
    }
}
