using Sample.Chunkers.Infrastructure;
using Sample.Chunkers.Strategies.IndexesExtractors;
using Sample.Chunkers.Strategies.MarkdownExtractors;
using Sample.Chunkers.Models;
using Sample.Chunkers.Models.Enums;
using System.Text;

namespace Sample.Chunkers.Extensions;

/// <summary>
/// Предоставляет методы расширения для извлечения структурированных элементов (код, таблицы, ссылки и т.д.) из текста.
/// </summary>
public static class ComplexDataChunkerExtensions
{
    private static readonly ChunkTypesRegexProvider regexProvider = new();
    private static readonly Dictionary<string, ChunkType> labelsChunkTypesPairs = new()
    {
        ["Title"] = ChunkType.Topic,
        ["Table"] = ChunkType.Table,
        ["Math-Block"] = ChunkType.MathBlock,
        ["Code-Block"] = ChunkType.CodeBlock,
        ["Info-Block"] = ChunkType.InfoBlock,
        ["Image-Link"] = ChunkType.ImageLink,
        ["External-Link"] = ChunkType.AdditionalLink,
    };

    private static readonly IMarkdownChunksExtractor ChunksExtractorsChain;

    private static readonly Dictionary<string, IMarkdownChunksExtractor> ChunkTypesExtractorsPairs = new()
    {
        ["Heading"] = new MarkdownHeadingExtractor(regexProvider),
        ["HtmlTable"] = new MarkdownHtmlTableExtractor(regexProvider),
        ["CodeBlock"] = new MarkdownCodeBlockExtractor(regexProvider),
        ["UnusualBlock"] = new MarkdownUnusualCodeBlockExtractor(regexProvider),
        ["InfoBlock"] = new MarkdownInfoBlockExtractor(regexProvider),
        ["ExternalLink"] = new MarkdownExternalLinksExtractor(regexProvider),
        ["ImageLink"] = new MarkdownImageLinksExtractor(regexProvider),
    };

    static ComplexDataChunkerExtensions()
    {
        ChunksExtractorsChain = ChunkTypesExtractorsPairs["CodeBlock"];

        ChunksExtractorsChain.SetNext(ChunkTypesExtractorsPairs["UnusualBlock"])
            .SetNext(ChunkTypesExtractorsPairs["HtmlTable"])
            .SetNext(ChunkTypesExtractorsPairs["InfoBlock"])
            .SetNext(ChunkTypesExtractorsPairs["ImageLink"])
            .SetNext(ChunkTypesExtractorsPairs["ExternalLink"])
            .SetNext(ChunkTypesExtractorsPairs["Heading"]);
    }

    /// <summary>
    /// Обрабатывает коллекцию документов с автоматической нумерацией чанков.
    /// </summary>
    /// <typeparam name="T">Тип ключа словаря (должен быть unmanaged типом: int, long, Guid и т.д.).</typeparam>
    /// <param name="texts">Словарь документов: ключ → текст.</param>
    /// <param name="chunkWordsCount">Максимальное количество слов в текстовом чанке.</param>
    /// <param name="indexesExtractor">Тип семантической единицы: предложение или параграф.</param>
    /// <param name="overlapPercentage">Процент перекрытия между чанками (от 0.0 до 1.0). По умолчанию 0.0.</param>
    /// <returns>Словарь документов → типы чанков → списки чанков. Индексы чанков накапливаются между документами.</returns>
    public static Dictionary<T, Dictionary<ChunkType, List<ChunkModel>>> ExtractSemanticChunksDeeply<T>(this Dictionary<T, string> texts, 
        int chunkWordsCount,
        IPrimitivesIndexesExtractor indexesExtractor, 
        double overlapPercentage = 0.0)
        where T : unmanaged
    {
        var result = new Dictionary<T, Dictionary<ChunkType, List<ChunkModel>>>();

        var lastUsedIndex = 0;

        foreach (var text in texts)
        {
            var chunks = text.Value.ExtractSemanticChunksDeeply(chunkWordsCount, indexesExtractor, overlapPercentage, lastUsedIndex);
            lastUsedIndex += chunks.SelectMany(x => x.Value).Count();

            result[text.Key] = chunks;
        }

        return result;
    }

    /// <summary>
    /// Извлекает все типы чанков из одного текста: структурированные элементы (код, таблицы, ссылки) и текстовые чанки.
    /// </summary>
    /// <param name="text">Текст для обработки (Markdown или HTML).</param>
    /// <param name="chunkWordsCount">Максимальное количество слов в текстовом чанке.</param>
    /// <param name="indexesExtractor">Тип семантической единицы: предложение или параграф.</param>
    /// <param name="overlapPercentage">Процент перекрытия между чанками (от 0.0 до 1.0). По умолчанию 0.0.</param>
    /// <param name="lastUsedIndex">Последний использованный индекс (для продолжения нумерации). По умолчанию 0.</param>
    /// <returns>Словарь типов чанков → списки чанков.</returns>
    /// <remarks>
    /// Порядок обработки:
    /// <list type="number">
    /// <item>Извлекаются структурированные элементы (код, таблицы, ссылки и т.д.)</item>
    /// <item>Элементы заменяются на плейсхолдеры в тексте</item>
    /// <item>Текст предобрабатывается</item>
    /// <item>Извлекаются текстовые чанки</item>
    /// <item>В текстовых чанках обнаруживаются ссылки на извлеченные элементы</item>
    /// </list>
    /// </remarks>
    public static Dictionary<ChunkType, List<ChunkModel>> ExtractSemanticChunksDeeply(this string text,
        int chunkWordsCount,
        IPrimitivesIndexesExtractor indexesExtractor, 
        double overlapPercentage = 0.0,
        int lastUsedIndex = 0)
    {
        var textBuilder = new StringBuilder(text);

        var dataChunks = textBuilder.RetrieveChunksFromText(lastUsedIndex);
        var processedText = textBuilder.SquashLabelsIntoWords()
                                       .PreprocessNaturalTextForChunking();

        var index = lastUsedIndex;
        foreach (var pair in dataChunks)
        {
            foreach (var chunk in pair.Value)
            {
                index = Math.Max(index, chunk.Index);
            }
        }

        dataChunks[ChunkType.TextChunk] = processedText.ExtractSemanticChunks(index, chunkWordsCount, indexesExtractor, overlapPercentage);

        return dataChunks;
    }

    /// <summary>
    /// Извлекает только структурированные элементы из текста без текстовых чанков.
    /// </summary>
    /// <param name="text">Текст для обработки (Markdown или HTML).</param>
    /// <param name="lastUsedIndex">Последний использованный индекс (для продолжения нумерации). По умолчанию 0.</param>
    /// <returns>Словарь типов чанков → списки чанков. Текстовые чанки (TextChunk) не извлекаются.</returns>
    /// <remarks>
    /// Используется когда нужны только структурированные элементы без текстовых чанков.
    /// Порядок извлечения: блоки кода → таблицы → info blocks → изображения → ссылки → заголовки.
    /// </remarks>
    public static Dictionary<ChunkType, List<ChunkModel>> RetrieveChunksFromText(this string text, int lastUsedIndex = 0)
    {
        var currentText = new StringBuilder(text);

        return currentText.RetrieveChunksFromText(lastUsedIndex);
    }

    private static Dictionary<ChunkType, List<ChunkModel>> RetrieveChunksFromText(this StringBuilder text, int lastUsedIndex = 0)
    {
        var result = ChunksExtractorsChain.ExtractChunksFromText(text, lastUsedIndex)
            .GroupBy(x => x.ChunkType)
            .ToDictionary(x => x.Key, x => x.ToList());

        foreach (var pair in labelsChunkTypesPairs)
        {
            if (!result.ContainsKey(pair.Value))
            {
                result[pair.Value] = [];
            }
        }

        return result;
    }

    private static List<ChunkModel> ExtractSemanticChunks(this string text, int lastUsedIndex, int chunkWordsCount, IPrimitivesIndexesExtractor indexesExtractor, double overlapPercentage = 0.0)
    {
        var result = new List<ChunkModel>();
        var textChunks = text.ExtractSemanticChunksFromText(chunkWordsCount, indexesExtractor, overlapPercentage);

        foreach (var item in textChunks)
        {
            var rawChunkData = new StringBuilder(item);
            var relatedIndexes = ExtractRelatedChunksIndexes(rawChunkData);

            result.Add(new ChunkModel
            {
                Index = ++lastUsedIndex,
                ChunkType = ChunkType.TextChunk,
                RawContent = rawChunkData.ToString(),
                Data = new Dictionary<string, object>
                {
                    ["content"] = rawChunkData.ToString(),
                },
                RelatedChunksIndexes = relatedIndexes,
            });
        }

        return [.. result];
    }

    private static string SquashLabelsIntoWords(this StringBuilder text)
    {
        var matches = regexProvider.GetChunkLabelWithWhitespacesRegex()
            .Matches(text.ToString())
            .ToArray();

        foreach (var match in matches)
        {
            text.Replace(match.Value, match.Groups[1].Value);
        }

        return text.ToString();
    }

    private static Dictionary<ChunkType, List<int>> ExtractRelatedChunksIndexes(this StringBuilder chunkValue)
    {
        var result = new Dictionary<ChunkType, List<int>>();
        var matches = regexProvider.GetChunkLabelRegex()
            .Matches(chunkValue.ToString())
            .ToArray();

        foreach (var match in matches) 
        {
            if (labelsChunkTypesPairs.TryGetValue(match.Groups[1].Value, out var type))
            {
                if (!result.TryGetValue(type, out var value))
                {
                    value = [];
                    result.Add(type, value);
                }

                value.Add(int.Parse(match.Groups[2].Value));
            }

            chunkValue.Replace(match.Value, string.Empty);
        }

        return result;
    }
}
