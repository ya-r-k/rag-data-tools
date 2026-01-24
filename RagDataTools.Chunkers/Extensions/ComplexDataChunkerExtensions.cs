using RagDataTools.Chunkers.Infrastructure;
using RagDataTools.Chunkers.Strategies.IndexesExtractors;
using RagDataTools.Chunkers.Strategies.MarkdownExtractors;
using RagDataTools.Chunkers.Models;
using RagDataTools.Chunkers.Models.Enums;
using System.Text;

namespace RagDataTools.Chunkers.Extensions;

/// <summary>
/// Предоставляет методы расширения для извлечения структурированных элементов (код, таблицы, ссылки и т.д.) из текста.
/// </summary>
public static class ComplexDataChunkerExtensions
{
    private static readonly ChunkTypesRegexProvider regexProvider = new();
    private static readonly Dictionary<string, RelationshipType> labelsChunkTypesPairs = new()
    {
        ["Title"] = RelationshipType.StartsWith,
        ["Table"] = RelationshipType.RelatedTable,
        ["Math-Block"] = RelationshipType.RelatedMathBlock,
        ["Code-Block"] = RelationshipType.RelatedCodeBlock,
        ["Info-Block"] = RelationshipType.RelatedInfoBlock,
        ["Image-Link"] = RelationshipType.RelatedImage,
        ["External-Link"] = RelationshipType.AdditionalLink,
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
    public static Dictionary<T, ChunkModel[]> ExtractSemanticChunksDeeply<T>(this Dictionary<T, string> texts, 
        int chunkWordsCount,
        IPrimitivesIndexesExtractor indexesExtractor, 
        double overlapPercentage = 0.0)
        where T : unmanaged
    {
        var result = new Dictionary<T, ChunkModel[]>();

        var lastUsedIndex = 0;

        foreach (var text in texts)
        {
            var chunks = text.Value.ExtractSemanticChunksDeeply(chunkWordsCount, indexesExtractor, overlapPercentage, lastUsedIndex);
            lastUsedIndex += chunks.Length;

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
    public static ChunkModel[] ExtractSemanticChunksDeeply(this string text,
        int chunkWordsCount,
        IPrimitivesIndexesExtractor indexesExtractor, 
        double overlapPercentage = 0.0,
        int lastUsedIndex = 0)
    {
        var textBuilder = new StringBuilder(text);

        var dataChunks = ChunksExtractorsChain.ExtractChunksFromText(textBuilder, lastUsedIndex);
        var processedText = textBuilder.SquashLabelsIntoWords()
                                       .PreprocessNaturalTextForChunking();

        var index = lastUsedIndex;
        foreach (var chunk in dataChunks)
        {
            index = Math.Max(index, chunk.Index);
        }

        dataChunks.AddRange(processedText.ExtractSemanticChunks(index, chunkWordsCount, indexesExtractor, overlapPercentage));

        return [.. dataChunks];
    }

    private static ChunkModel[] ExtractSemanticChunks(this string text, int lastUsedIndex, int chunkWordsCount, IPrimitivesIndexesExtractor indexesExtractor, double overlapPercentage = 0.0)
    {
        var result = new List<ChunkModel>();
        var textChunks = text.ExtractSemanticChunksFromText(chunkWordsCount, indexesExtractor, overlapPercentage);

        for (var i = 0; i < textChunks.Length; i++)
        {
            var rawChunkData = new StringBuilder(textChunks[i]);
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

            if (i < textChunks.Length - 1)
            {
                relatedIndexes[RelationshipType.HasNextChunk] = [lastUsedIndex + 1];
            }
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

    private static Dictionary<RelationshipType, List<int>> ExtractRelatedChunksIndexes(this StringBuilder chunkValue)
    {
        var result = new Dictionary<RelationshipType, List<int>>();
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
