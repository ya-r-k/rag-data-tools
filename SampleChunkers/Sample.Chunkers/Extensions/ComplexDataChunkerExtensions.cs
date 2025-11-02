using Sample.Chunkers.Enums;
using Sample.Chunkers.Helpers;
using Sample.Chunkers.Models;
using System.Text;
using System.Text.RegularExpressions;

namespace Sample.Chunkers.Extensions;

/// <summary>
/// Предоставляет методы расширения для извлечения структурированных элементов (код, таблицы, ссылки и т.д.) из текста.
/// </summary>
public static class ComplexDataChunkerExtensions
{
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

    /// <summary>
    /// Обрабатывает коллекцию документов с автоматической нумерацией чанков.
    /// </summary>
    /// <typeparam name="T">Тип ключа словаря (должен быть unmanaged типом: int, long, Guid и т.д.).</typeparam>
    /// <param name="texts">Словарь документов: ключ → текст.</param>
    /// <param name="chunkWordsCount">Максимальное количество слов в текстовом чанке.</param>
    /// <param name="semanticsType">Тип семантической единицы: предложение или параграф.</param>
    /// <param name="overlapPercentage">Процент перекрытия между чанками (от 0.0 до 1.0). По умолчанию 0.0.</param>
    /// <param name="withTables">Извлекать HTML таблицы. По умолчанию true.</param>
    /// <param name="withInfoBlocks">Извлекать информационные блоки (blockquotes). По умолчанию true.</param>
    /// <param name="withCodeBlocks">Извлекать блоки кода. По умолчанию true.</param>
    /// <param name="withImages">Извлекать изображения. По умолчанию true.</param>
    /// <param name="withLinks">Извлекать внешние ссылки. По умолчанию true.</param>
    /// <returns>Словарь документов → типы чанков → списки чанков. Индексы чанков накапливаются между документами.</returns>
    public static Dictionary<T, Dictionary<ChunkType, List<ChunkModel>>> ExtractSemanticChunksDeeply<T>(this Dictionary<T, string> texts, 
        int chunkWordsCount, 
        SemanticsType semanticsType, 
        double overlapPercentage = 0.0, 
        bool withTables = true,
        bool withInfoBlocks = true,
        bool withCodeBlocks = true, 
        bool withImages = true, 
        bool withLinks = true)
        where T : unmanaged
    {
        var result = new Dictionary<T, Dictionary<ChunkType, List<ChunkModel>>>();

        var lastUsedIndex = 0;

        foreach (var text in texts)
        {
            var chunks = text.Value.ExtractSemanticChunksDeeply(chunkWordsCount, semanticsType, overlapPercentage, withTables, withInfoBlocks, withCodeBlocks, withImages, withLinks, lastUsedIndex);
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
    /// <param name="semanticsType">Тип семантической единицы: предложение или параграф.</param>
    /// <param name="overlapPercentage">Процент перекрытия между чанками (от 0.0 до 1.0). По умолчанию 0.0.</param>
    /// <param name="withTables">Извлекать HTML таблицы. По умолчанию true.</param>
    /// <param name="withInfoBlocks">Извлекать информационные блоки (blockquotes). По умолчанию true.</param>
    /// <param name="withCodeBlocks">Извлекать блоки кода. По умолчанию true.</param>
    /// <param name="withImages">Извлекать изображения. По умолчанию true.</param>
    /// <param name="withLinks">Извлекать внешние ссылки. По умолчанию true.</param>
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
        SemanticsType semanticsType, 
        double overlapPercentage = 0.0, 
        bool withTables = true,
        bool withInfoBlocks = true,
        bool withCodeBlocks = true, 
        bool withImages = true, 
        bool withLinks = true, 
        int lastUsedIndex = 0)
    {
        var textBuilder = new StringBuilder(text);

        var dataChunks = textBuilder.RetrieveChunksFromText(withTables, withInfoBlocks, withCodeBlocks, withImages, withLinks, lastUsedIndex);
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

        dataChunks[ChunkType.TextChunk] = processedText.ExtractSemanticChunks(index, chunkWordsCount, semanticsType, overlapPercentage);

        return dataChunks;
    }

    /// <summary>
    /// Извлекает только структурированные элементы из текста без текстовых чанков.
    /// </summary>
    /// <param name="text">Текст для обработки (Markdown или HTML).</param>
    /// <param name="withTables">Извлекать HTML таблицы.</param>
    /// <param name="withInfoBlocks">Извлекать информационные блоки (blockquotes).</param>
    /// <param name="withCodeBlocks">Извлекать блоки кода.</param>
    /// <param name="withImages">Извлекать изображения.</param>
    /// <param name="withLinks">Извлекать внешние ссылки.</param>
    /// <param name="lastUsedIndex">Последний использованный индекс (для продолжения нумерации). По умолчанию 0.</param>
    /// <returns>Словарь типов чанков → списки чанков. Текстовые чанки (TextChunk) не извлекаются.</returns>
    /// <remarks>
    /// Используется когда нужны только структурированные элементы без текстовых чанков.
    /// Порядок извлечения: блоки кода → таблицы → info blocks → изображения → ссылки → заголовки.
    /// </remarks>
    public static Dictionary<ChunkType, List<ChunkModel>> RetrieveChunksFromText(this string text, bool withTables, bool withInfoBlocks, bool withCodeBlocks, bool withImages, bool withLinks, int lastUsedIndex = 0)
    {
        var currentText = new StringBuilder(text);

        return currentText.RetrieveChunksFromText(withTables, withInfoBlocks, withCodeBlocks, withImages, withLinks, lastUsedIndex);
    }

    private static Dictionary<ChunkType, List<ChunkModel>> RetrieveChunksFromText(this StringBuilder text, bool withTables, bool withInfoBlocks, bool withCodeBlocks, bool withImages, bool withLinks, int lastUsedIndex = 0)
    {
        var result = new Dictionary<ChunkType, List<ChunkModel>>();
        var index = lastUsedIndex;

        if (withCodeBlocks)
        {
            var items = text.ExtractMarkdownCodeBlocks(index);
            items.AddRange(text.ExtractMarkdownUnusualCodeBlocks(index + items.Count));

            result.Add(ChunkType.CodeBlock, items);
            index += items.Count;
        }

        if (withTables)
        {
            var items = text.ExtractHtmlTables(index);

            result.Add(ChunkType.Table, items);
            index += items.Count;
        }

        if (withInfoBlocks)
        {
            var items = text.ExtractMarkdownInfoBlocks(index);

            result.Add(ChunkType.InfoBlock, items);
            index += items.Count;
        }

        if (withImages)
        {
            var items = text.ExtractMarkdownImageLinks(index);

            result.Add(ChunkType.ImageLink, items);
            index += items.Count;
        }

        if (withLinks)
        {
            var items = ExtractMarkdownLinks(text, index);

            result.Add(ChunkType.AdditionalLink, items);
            index += items.Count;
        }

        result.Add(ChunkType.Topic, text.ExtractMarkdownHeaders(index));

        return result;
    }

    private static List<ChunkModel> ExtractSemanticChunks(this string text, int lastUsedIndex, int chunkWordsCount, SemanticsType semanticsType, double overlapPercentage = 0.0)
    {
        var result = new List<ChunkModel>();
        var textChunks = text.ExtractSemanticChunksFromText(chunkWordsCount, semanticsType, overlapPercentage);

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
        var matches = ChunkTypesRegexHelper.GetChunkLabelWithWhitespacesRegex().Matches(text.ToString());

        foreach (Match match in matches)
        {
            text.Replace(match.Value, match.Groups[1].Value);
        }

        return text.ToString();
    }

    private static List<ChunkModel> ExtractMarkdownInfoBlocks(this StringBuilder text, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();
        var matches = ChunkTypesRegexHelper.GetMarkdownInfoBlockRegex()
                                           .Matches(text.ToString());

        foreach (Match match in matches)
        {
            var infoBlockContent = match.Value.Trim();

            result.Add(new ChunkModel
            {
                Index = ++lastUsedIndex,
                RawContent = infoBlockContent,
                ChunkType = ChunkType.InfoBlock,
                Data = new Dictionary<string, object>()
                {
                    ["content"] = infoBlockContent,
                },
                RelatedChunksIndexes = [],
            });

            text.Replace(match.Value, string.Format(ChunksConsts.InfoBlockTemplate, lastUsedIndex));
        }

        return [.. result];
    }

    private static List<ChunkModel> ExtractMarkdownCodeBlocks(this StringBuilder text, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();
        var matches = ChunkTypesRegexHelper.GetCodeBlockRegex()
                                           .Matches(text.ToString());

        foreach (Match match in matches)
        {
            var codeBlockContent = match.Value.Trim();

            var language = match.Groups[1].Value; // Название языка (если указано)
            language = string.IsNullOrEmpty(language) ? "unknown" : language.ToLower();

            result.Add(new ChunkModel
            {
                Index = ++lastUsedIndex,
                RawContent = codeBlockContent,
                ChunkType = ChunkType.CodeBlock,
                Data = new Dictionary<string, object>()
                {
                    ["language"] = language,
                    ["content"] = codeBlockContent,
                },
                RelatedChunksIndexes = [],
            });

            text.Replace(codeBlockContent, string.Format(ChunksConsts.CodeBlockTemplate, lastUsedIndex));
        }

        return [.. result];
    }

    private static List<ChunkModel> ExtractMarkdownUnusualCodeBlocks(this StringBuilder text, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();
        var matches = ChunkTypesRegexHelper.GetUnusualCodeBlockRegex()
                                           .Matches(text.ToString());

        foreach (Match match in matches)
        {
            var codeBlockContent = match.Value.Trim();

            result.Add(new ChunkModel
            {
                Index = ++lastUsedIndex,
                RawContent = codeBlockContent,
                ChunkType = ChunkType.CodeBlock,
                Data = new Dictionary<string, object>()
                {
                    ["language"] = "unknown",
                    ["content"] = codeBlockContent,
                },
                RelatedChunksIndexes = [],
            });

            text.Replace(codeBlockContent, string.Format(ChunksConsts.CodeBlockTemplate, lastUsedIndex));
        }

        return [.. result];
    }

    private static List<ChunkModel> ExtractHtmlTables(this StringBuilder text, int lastUsedIndex = 0)
    {
        var rawText = text.ToString();
        var result = new List<ChunkModel>();
        var tagsMatches = ChunkTypesRegexHelper.GetHtmlTableTagsRegex().Matches(rawText);
        var depth = 0;
        var startIndex = -1;

        foreach (Match tagMatch in tagsMatches)
        {
            var isClosing = tagMatch.Groups[1].Value.Length != 0;

            if (!isClosing)
            {
                if (depth == 0)
                {
                    startIndex = tagMatch.Index;
                }

                depth++;
            }
            else
            {
                depth--;

                if (depth == 0 && startIndex >= 0)
                {
                    var endIndex = tagMatch.Index + tagMatch.Length;
                    var tableBlockContent = rawText[startIndex..endIndex];
                    
                    result.Add(new ChunkModel
                    {
                        Index = ++lastUsedIndex,
                        RawContent = tableBlockContent,
                        ChunkType = ChunkType.Table,
                        Data = new Dictionary<string, object>
                        {
                            ["content"] = tableBlockContent,
                        },
                        RelatedChunksIndexes = []
                    });
                    text.Replace(tableBlockContent, string.Format(ChunksConsts.TableTemplate, lastUsedIndex));

                    startIndex = -1;
                }
            }
        }

        return [.. result];
    }

    private static List<ChunkModel> ExtractMarkdownImageLinks(this StringBuilder text, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();
        var matches = ChunkTypesRegexHelper.GetImageLinkRegex().Matches(text.ToString());

        foreach (Match match in matches)
        {
            result.Add(new ChunkModel
            {
                Index = ++lastUsedIndex,
                RawContent = match.Value,
                ChunkType = ChunkType.ImageLink,
                Data = new Dictionary<string, object>
                {
                    ["url"] = match.Groups[2].Value,
                    ["alterText"] = match.Groups[1].Value,
                },
                RelatedChunksIndexes = []
            });

            text.Replace(match.Value, string.Format(ChunksConsts.ImageLinkTemplate, lastUsedIndex));
        }

        return [.. result];
    }

    private static List<ChunkModel> ExtractMarkdownHeaders(this StringBuilder text, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();
        var matches = ChunkTypesRegexHelper.GetHeadingRegex().Matches(text.ToString());

        foreach (Match match in matches)
        {
            var titleText = new StringBuilder(match.Groups[2].Value.TrimEnd());
            var relatedIndexes = titleText.ExtractRelatedChunksIndexes();

            result.Add(new ChunkModel
            {
                Index = ++lastUsedIndex,
                RawContent = match.Value.TrimEnd(),
                ChunkType = ChunkType.Topic,
                Data = new Dictionary<string, object>
                {
                    ["name"] = titleText.ToString(),
                    ["level"] = match.Groups[1].Length,
                },
                RelatedChunksIndexes = relatedIndexes,
            });

            text.Replace(match.Value, string.Format(ChunksConsts.HeaderTemplate, lastUsedIndex));
        }

        return [.. result];
    }

    private static List<ChunkModel> ExtractMarkdownLinks(this StringBuilder text, int lastUsedIndex = 0)
    {
        var result = new List<ChunkModel>();

        // Регулярное выражение для поиска Markdown-ссылок ([Alt текст](URL))
        var matches = ChunkTypesRegexHelper.GetExternalLinkRegex().Matches(text.ToString());

        foreach (Match match in matches)
        {
            var textDescription = match.Groups[1].Value;
            result.Add(new ChunkModel
            {
                Index = ++lastUsedIndex,
                RawContent = match.Value,
                ChunkType = ChunkType.AdditionalLink,
                Data = new Dictionary<string, object>
                {
                    ["url"] = match.Groups[2].Value,
                    ["alterText"] = textDescription,
                },
                RelatedChunksIndexes = []
            });

            text.Replace(match.Value, textDescription + string.Format(ChunksConsts.ExternalLinkTemplate, lastUsedIndex));
        }

        return [.. result];
    }

    private static Dictionary<ChunkType, List<int>> ExtractRelatedChunksIndexes(this StringBuilder chunkValue)
    {
        var result = new Dictionary<ChunkType, List<int>>();
        var matches = ChunkTypesRegexHelper.GetChunkLabelRegex().Matches(chunkValue.ToString());

        foreach (Match match in matches) 
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
