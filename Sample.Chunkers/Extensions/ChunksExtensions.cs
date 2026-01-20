using Sample.Chunkers.Models;
using Sample.Chunkers.Models.Enums;

namespace Sample.Chunkers.Extensions;

/// <summary>
/// Предоставляет методы расширения для работы с коллекциями чанков: построение графа связей и поиск дубликатов.
/// </summary>
public static class ChunksExtensions
{
    private static readonly Dictionary<ChunkType, RelationshipType> RelatedChunkRelationshipType = new()
    {
        [ChunkType.Topic] = RelationshipType.StartsWith,
        [ChunkType.CodeBlock] = RelationshipType.RelatedCodeBlock,
        [ChunkType.InfoBlock] = RelationshipType.RelatedInfoBlock,
        [ChunkType.ImageLink] = RelationshipType.RelatedImage,
        [ChunkType.Table] = RelationshipType.RelatedTable,
        [ChunkType.AdditionalLink] = RelationshipType.AdditionalLink,
    };

    private static readonly ChunkType[] ChunkTypesWithUrls =
    [
        ChunkType.ImageLink,
        ChunkType.AdditionalLink,
    ];

    private static readonly ChunkType[] RelatedChunkTypeSequence =
    [
        ChunkType.Topic,
        ChunkType.CodeBlock,
        ChunkType.InfoBlock,
        ChunkType.ImageLink,
        ChunkType.Table,
        ChunkType.AdditionalLink,
    ];

    /// <summary>
    /// Находит дубликаты чанков с одинаковыми URL (изображения и ссылки).
    /// </summary>
    /// <typeparam name="T">Тип ключа словаря (должен быть unmanaged типом).</typeparam>
    /// <param name="chunks">Словарь документов → типы чанков → списки чанков.</param>
    /// <returns>Словарь повторяющийся_индекс → уникальный_индекс. Первый найденный чанк с URL считается уникальным.</returns>
    /// <remarks>
    /// Работает только с чанками типа ImageLink и AdditionalLink.
    /// Алгоритм:
    /// <list type="number">
    /// <item>Находит все чанки с URL (ImageLink, AdditionalLink)</item>
    /// <item>Группирует по URL</item>
    /// <item>Для каждого URL оставляет первый индекс как уникальный</item>
    /// <item>Остальные индексы добавляет в результат как повторяющиеся</item>
    /// </list>
    /// </remarks>
    public static Dictionary<int, int> FindRepeatedChunksWithUrls<T>(this Dictionary<T, Dictionary<ChunkType, List<ChunkModel>>> chunks)
        where T : unmanaged
    {
        var result = new Dictionary<int, int>();
        var urlMap = chunks.SelectMany(x => x.Value)
                           .Where(x => ChunkTypesWithUrls.Contains(x.Key))
                           .SelectMany(x => x.Value)
                           .Select(x => new {
                               Url = x.Data.TryGetValue("url", out var u) && u is string s ? s : null,
                               ChunkIndex = x.Index,
                           })
                           .Where(x => !string.IsNullOrEmpty(x.Url))
                           .GroupBy(x => x.Url!)
                           .ToDictionary(g => g.Key, g => g.Select(x => x.ChunkIndex).ToArray());

        foreach (var urlItem in urlMap)
        {
            if (urlItem.Value.Length > 1)
            {
                var uniqueItemIndex = urlItem.Value[0];

                for (var i = 1; i < urlItem.Value.Length; i++)
                {
                    result[urlItem.Value[i]] = uniqueItemIndex;
                }
            }
        }

        return result;
    }

    /// <summary>
    /// Строит граф связей для коллекции документов.
    /// </summary>
    /// <typeparam name="T">Тип ключа словаря (должен быть unmanaged типом).</typeparam>
    /// <param name="chunks">Словарь документов → типы чанков → списки чанков.</param>
    /// <returns>Массив связей между чанками различных типов.</returns>
    /// <remarks>
    /// Создает следующие типы связей:
    /// <list type="bullet">
    /// <item>HasNextChunk - между последовательными текстовыми чанками</item>
    /// <item>HasNextTopic, HasFirstSubtopic - иерархия заголовков</item>
    /// <item>RelatedCodeBlock, RelatedTable, RelatedImage, RelatedInfoBlock, AdditionalLink - связи из RelatedChunksIndexes</item>
    /// </list>
    /// </remarks>
    public static RelationshipModel[] BuildRelationsGraph<T>(this Dictionary<T, Dictionary<ChunkType, List<ChunkModel>>> chunks)
        where T : unmanaged
    {
        var result = new List<RelationshipModel>();

        foreach (var item in chunks)
        {
            result.AddRange(item.Value.BuildRelationsGraph());
        }

        return [.. result];
    }

    /// <summary>
    /// Строит граф связей для одного документа.
    /// </summary>
    /// <param name="chunks">Словарь типов чанков → списки чанков.</param>
    /// <returns>Массив связей между чанками.</returns>
    /// <remarks>
    /// Создает следующие типы связей:
    /// <list type="bullet">
    /// <item>HasNextChunk - между последовательными текстовыми чанками (индексы идут подряд)</item>
    /// <item>HasNextTopic - следующий заголовок того же или более высокого уровня</item>
    /// <item>HasFirstSubtopic - первый подзаголовок (более низкого уровня)</item>
    /// <item>RelatedCodeBlock, RelatedTable, RelatedImage, RelatedInfoBlock, AdditionalLink, StartsWith - из RelatedChunksIndexes каждого чанка</item>
    /// </list>
    /// </remarks>
    public static RelationshipModel[] BuildRelationsGraph(this Dictionary<ChunkType, List<ChunkModel>> chunks)
    {
        var result = new List<RelationshipModel>();

        if (chunks.TryGetValue(ChunkType.TextChunk, out var headersChunks))
        {
            result.AddRange(headersChunks.BuildTextChunkSequenceRelations());
        }

        if (chunks.TryGetValue(ChunkType.Topic, out var textChunks))
        {
            result.AddRange(textChunks.BuildTitlesSequenceRelations());
        }

        foreach (var value in chunks.Values)
        {
            foreach (var chunk in value)
            {
                result.AddRange(chunk.BuildRelationshipsForRelatedChunks());
            }
        }

        return [.. result];
    }

    private static List<RelationshipModel> BuildTitlesSequenceRelations(this List<ChunkModel> sequenceChunks)
    {
        if (sequenceChunks.Count == 0)
            return [];

        var result = new List<RelationshipModel>();
        var titlesPrevIndexes = new Dictionary<int, int>
        {
            [(int)sequenceChunks[0].Data["level"]] = sequenceChunks[0].Index
        }; // Уровень -> последний индекс

        for (int i = 1; i < sequenceChunks.Count; i++)
        {
            var prev = sequenceChunks[i - 1];
            var current = sequenceChunks[i];

            if (current.Index - prev.Index != 1)
                continue;

            var currentLevel = (int)current.Data["level"];
            var prevLevel = (int)prev.Data["level"];

            var relType = currentLevel > prevLevel
                ? RelationshipType.HasFirstSubtopic
                : RelationshipType.HasNextTopic;

            if (currentLevel < prevLevel)
            {
                if (titlesPrevIndexes.TryGetValue(currentLevel, out int lastSameLevelIndex))
                {
                    result.Add(new RelationshipModel
                    {
                        FirstChunkIndex = lastSameLevelIndex,
                        SecondChunkIndex = current.Index,
                        RelationshipType = relType
                    });
                }
            }
            else
            {
                result.Add(new RelationshipModel
                {
                    FirstChunkIndex = prev.Index,
                    SecondChunkIndex = current.Index,
                    RelationshipType = relType
                });
            }

            titlesPrevIndexes[currentLevel] = current.Index;
        }

        return result;
    }

    private static List<RelationshipModel> BuildTextChunkSequenceRelations(this List<ChunkModel> sequenceChunks)
    {
        if (sequenceChunks.Count == 0)
        {
            return [];
        }

        var result = new List<RelationshipModel>();

        for (var i = 1; i < sequenceChunks.Count; i++)
        {
            if (sequenceChunks[i].Index - sequenceChunks[i - 1].Index == 1)
            {
                result.Add(new RelationshipModel
                {
                    FirstChunkIndex = sequenceChunks[i - 1].Index,
                    SecondChunkIndex = sequenceChunks[i].Index,
                    RelationshipType = RelationshipType.HasNextChunk,
                });
            }
        }

        return result;
    }

    private static List<RelationshipModel> BuildRelationshipsForRelatedChunks(this ChunkModel firstChunk)
    {
        if (firstChunk.RelatedChunksIndexes.Count == 0)
        {
            return [];
        }

        var result = new List<RelationshipModel>();

        foreach (var chunkType in RelatedChunkTypeSequence)
        {
            var isCurrentChunkFirst = chunkType != ChunkType.Topic;

            if (firstChunk.RelatedChunksIndexes.TryGetValue(chunkType, out var indexes))
            {
                result.AddRange(indexes.Select(x => new RelationshipModel
                {
                    FirstChunkIndex = isCurrentChunkFirst ? firstChunk.Index : x,
                    SecondChunkIndex = isCurrentChunkFirst ? x : firstChunk.Index,
                    RelationshipType = RelatedChunkRelationshipType[chunkType],
                }));
            }
        }

        return result;
    }
}
