using RagDataTools.Chunkers.Infrastructure;
using RagDataTools.Chunkers.Strategies.IndexesExtractors;

namespace RagDataTools.Chunkers.Extensions;

/// <summary>
/// Предоставляет методы расширения для работы с простым текстом без структурированных элементов.
/// </summary>
public static class NaiveTextChunkerExtensions
{
    private static readonly TextChunksRegexProvider regexProvider = new();

    private static readonly WordsIndexesExtractor wordsIndexesExtractor = new(regexProvider);

    /// <summary>
    /// Подготавливает текст для разбиения на чанки: удаляет лишние пробелы, нормализует переводы строк и специальные символы.
    /// </summary>
    /// <param name="text">Текст для предобработки.</param>
    /// <returns>Очищенный и нормализованный текст, готовый для разбиения на чанки.</returns>
    /// <remarks>
    /// Выполняет следующие операции:
    /// <list type="bullet">
    /// <item>Удаляет пробелы в начале и конце</item>
    /// <item>Заменяет неразрывные пробелы (\u00A0) на обычные пробелы</item>
    /// <item>Заменяет длинное тире (\u2014) на дефис</item>
    /// <item>Удаляет множественные пробелы</item>
    /// </list>
    /// </remarks>
    public static string PreprocessNaturalTextForChunking(this string text)
    {
        var cleaned = text.Trim()
                          .Replace('\u00A0', ' ')
                          .Replace(" \r\n", "\r\n")
                          .Replace(" \n", "\n")
                          .Replace("\r\n\r\n", "\n\n ")
                          .Replace("\r\n", "\n ")
                          .Replace('\u2018', '\'')
                          .Replace('\u2019', '\'')
                          .Replace('\u201C', '"')
                          .Replace('\u201D', '"')
                          .Replace("\u2014", "-");

        return regexProvider.GetMultipleSpacesRegex()
            .Replace(cleaned, " ");
    }

    /// <summary>
    /// Извлекает семантические чанки из текста, соблюдая границы предложений или параграфов.
    /// </summary>
    /// <param name="text">Текст для разбиения на чанки.</param>
    /// <param name="chunkWordsCount">Максимальное количество слов в одном чанке.</param>
    /// <param name="indexesExtractor">Тип семантической единицы: предложение или параграф.</param>
    /// <param name="overlapPercentage">Процент перекрытия между чанками (от 0.0 до 1.0). По умолчанию 0.0 (без перекрытия).</param>
    /// <returns>Массив текстовых чанков.</returns>
    /// <remarks>
    /// Алгоритм:
    /// <list type="number">
    /// <item>Предобрабатывает текст</item>
    /// <item>Разбивает на слова</item>
    /// <item>Определяет границы семантических единиц (предложения/параграфы)</item>
    /// <item>Создает чанки, соблюдая максимальный размер и границы семантики</item>
    /// <item>При перекрытии находит оптимальную точку начала следующего чанка</item>
    /// </list>
    /// Чанки не разрывают предложения или параграфы - они создаются только на границах семантических единиц.
    /// </remarks>
    public static string[] ExtractSemanticChunksFromText(this string text, int chunkWordsCount, IPrimitivesIndexesExtractor indexesExtractor, double overlapPercentage = 0.0)
    {
        var preprocessedText = PreprocessNaturalTextForChunking(text);

        var wordsIndexes = wordsIndexesExtractor.ExtractIndexes(preprocessedText);
        var semanticsIndexes = indexesExtractor.ExtractIndexes(preprocessedText);

        return GetChunks(wordsIndexes, semanticsIndexes, chunkWordsCount, preprocessedText, overlapPercentage);
    }

    private static string[] GetChunks(this int[] wordsIndexes, int[] semanticsIndexes, int chunkWordsCount, string text, double overlapPercentage = 0.0)
    {
        var chunks = new List<string>();
        var currentStartIndex = 0;
        var wordsOverlap = (int)(chunkWordsCount * overlapPercentage);

        while (currentStartIndex < text.Length)
        {
            var wordStartIndex = wordsIndexes.IndexOf(currentStartIndex);
            var wordMaxEndIndex = wordStartIndex + chunkWordsCount;
            
            var currentEndIndex = wordsIndexes.Length - wordStartIndex <= chunkWordsCount
                ? text.Length
                : semanticsIndexes.Where(x => x <= wordsIndexes[wordMaxEndIndex]).Max();

            var chunk = text[currentStartIndex..currentEndIndex];
            chunks.Add(chunk);

            if (currentEndIndex == text.Length) break;

            currentStartIndex = CalculateChunkStartIndex(semanticsIndexes, wordsIndexes, chunkWordsCount, wordsIndexes.IndexOf(currentEndIndex), wordsOverlap, wordStartIndex);
        }

        return [.. chunks];
    }

    private static int CalculateChunkStartIndex(int[] semanticsIndexes, int[] wordsIndexes, int chunkWordsCount, int wordEndIndex, int overlap, int wordStartIndex)
    {
        if (overlap <= 0)
        {
            return wordsIndexes[wordEndIndex];
        }

        var wordVeryEndIndex = wordStartIndex + chunkWordsCount;
        var target = wordVeryEndIndex - overlap;

        var bestIndex = wordEndIndex;
        var bestDistance = int.MaxValue;

        foreach (var index in semanticsIndexes)
        {
            var wordIndex = wordsIndexes.IndexOf(index);
            if (wordIndex <= wordStartIndex) continue;

            int distance = Math.Abs(wordIndex - target);
            if (distance < bestDistance)
            {
                bestDistance = distance;
                bestIndex = wordIndex;
            }
        }

        return wordsIndexes[bestIndex];
    }
}
