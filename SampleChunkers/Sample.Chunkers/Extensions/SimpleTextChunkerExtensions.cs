using Sample.Chunkers.Enums;
using Sample.Chunkers.Helpers;
using System.Text.RegularExpressions;

namespace Sample.Chunkers.Extensions;

/// <summary>
/// Предоставляет методы расширения для работы с простым текстом без структурированных элементов.
/// </summary>
public static class SimpleTextChunkerExtensions
{
    /// <summary>
    /// Разбивает текст на слова, используя пробелы как разделитель.
    /// </summary>
    /// <param name="text">Текст для разбиения на слова.</param>
    /// <returns>Span массива слов без пустых элементов.</returns>
    public static Span<string> GetWords(this string text)
    {
        return new Span<string>(text.Split([' '], StringSplitOptions.RemoveEmptyEntries));
    }

    /// <summary>
    /// Находит индексы начала предложений в массиве слов.
    /// Использует регулярное выражение для определения границ предложений (точка, восклицательный знак, вопросительный знак, двоеточие с переводом строки).
    /// </summary>
    /// <param name="text">Текст для анализа.</param>
    /// <returns>Массив индексов слов, с которых начинаются предложения.</returns>
    public static int[] ExtractSentenceStartIndices(this string text)
    {
        var indexes = new List<int>();
        int wordIndex = 0;
        var sentences = Regex.Split(text, @"(?<=[:]\n|\.|!|\?)\s+");

        foreach (var sentence in sentences)
        {
            indexes.Add(wordIndex);
            wordIndex += sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        return [.. indexes];
    }

    /// <summary>
    /// Находит индексы начала параграфов в массиве слов.
    /// Параграфы определяются по разделителю "\n " (новая строка с пробелом).
    /// </summary>
    /// <param name="text">Текст для анализа.</param>
    /// <returns>Массив индексов слов, с которых начинаются параграфы.</returns>
    public static int[] ExtractParagraphStartIndexes(this string text)
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
    /// <item>Нормализует переводы строк (\r\n → \n)</item>
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
                          .Replace("\u2014", "-");

        cleaned = CommonRegexHelper.GetMultipleSpacesRegex().Replace(cleaned, " ");

        return cleaned;
    }

    /// <summary>
    /// Предобрабатывает массив текстов для разбиения на чанки.
    /// </summary>
    /// <param name="texts">Массив текстов для предобработки.</param>
    /// <returns>Массив очищенных и нормализованных текстов.</returns>
    public static string[] PreprocessNaturalTextsForChunking(this string[] texts)
    {
        return [.. texts.Select(PreprocessNaturalTextForChunking)];
    }

    /// <summary>
    /// Извлекает семантические чанки из текста, соблюдая границы предложений или параграфов.
    /// </summary>
    /// <param name="text">Текст для разбиения на чанки.</param>
    /// <param name="chunkWordsCount">Максимальное количество слов в одном чанке.</param>
    /// <param name="semanticsType">Тип семантической единицы: предложение или параграф.</param>
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
    public static string[] ExtractSemanticChunksFromText(this string text, int chunkWordsCount, SemanticsType semanticsType, double overlapPercentage = 0.0)
    {
        var preprocessedText = PreprocessNaturalTextForChunking(text);
        var words = GetWords(preprocessedText);
        var semanticsIndexes = semanticsType switch
        {
            SemanticsType.Sentence => ExtractSentenceStartIndices(preprocessedText),
            SemanticsType.Paragraph => ExtractParagraphStartIndexes(preprocessedText),
            _ => throw new InvalidOperationException(),
        };

        return GetChunks(words, semanticsIndexes, chunkWordsCount, text, overlapPercentage);
    }

    private static string[] GetChunks(this Span<string> words, int[] semanticsIndexes, int chunkWordsCount, string text, double overlapPercentage = 0.0)
    {
        var chunks = new List<string>();
        var currentStartIndex = 0;
        int overlap = (int)(chunkWordsCount * overlapPercentage);

        while (currentStartIndex < words.Length)
        {
            var maxEndIndex = currentStartIndex + chunkWordsCount;

            var currentEndIndex = words.Length - currentStartIndex <= chunkWordsCount
                ? words.Length
                : semanticsIndexes.Where(x => x <= maxEndIndex).Max();

            var chunk = string.Join(" ", words[currentStartIndex..currentEndIndex].ToArray())
                              .Replace("\n ", "\n");
            chunks.Add(chunk);

            if (currentEndIndex == words.Length) break;

            currentStartIndex = CalculateChunkStartIndex(semanticsIndexes, chunkWordsCount, currentEndIndex, overlap, currentStartIndex);
        }

        return [.. chunks];
    }

    private static int CalculateChunkStartIndex(int[] semanticsIndexes, int maxChunkLength, int currentEndIndex, int overlap, int currentStartIndex)
    {
        if (overlap <= 0)
        {
            return currentEndIndex;
        }

        var veryEndIndex = currentStartIndex + maxChunkLength;
        var target = veryEndIndex - overlap;

        var bestIndex = currentEndIndex;
        var bestDistance = int.MaxValue;

        foreach (var index in semanticsIndexes)
        {
            if (index <= currentStartIndex) continue;

            int distance = Math.Abs(index - target);
            if (distance < bestDistance)
            {
                bestDistance = distance;
                bestIndex = index;
            }
        }

        return bestIndex;
    }
}
