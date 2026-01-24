using RagDataTools.Chunkers.Models;
using RagDataTools.Chunkers.Models.Enums;

namespace RagDataTools.Chunkers.Extensions;

/// <summary>
/// Предоставляет методы расширения для работы с коллекциями чанков: построение графа связей и поиск дубликатов.
/// </summary>
public static class ChunksExtensions
{
    private static readonly ChunkType[] ChunkTypesWithUrls =
    [
        ChunkType.ImageLink,
        ChunkType.AdditionalLink,
    ];

    private static readonly RelationshipType[] RelatedChunkTypeSequence =
    [
        RelationshipType.StartsWith,
        RelationshipType.HasNextChunk,
        RelationshipType.HasFirstSubtopic,
        RelationshipType.HasNextTopic,
        RelationshipType.RelatedCodeBlock,
        RelationshipType.RelatedInfoBlock,
        RelationshipType.RelatedImage,
        RelationshipType.RelatedTable,
        RelationshipType.AdditionalLink,
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
    public static Dictionary<int, int> FindRepeatedChunksWithUrls<T>(this Dictionary<T, ChunkModel[]> chunks)
        where T : unmanaged
    {
        var result = new Dictionary<int, int>();
        var urlMap = chunks.SelectMany(x => x.Value)
            .Where(x => ChunkTypesWithUrls.Contains(x.ChunkType))
            .Select(x => new {
                Url = x.Data.TryGetValue("url", out var u) && u is string s ? s : null,
                ChunkIndex = x.Index,
            }).Where(x => !string.IsNullOrEmpty(x.Url))
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
    public static RelationshipModel[] BuildRelationsGraph<T>(this Dictionary<T, ChunkModel[]> chunks)
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
    public static RelationshipModel[] BuildRelationsGraph(this ChunkModel[] chunks)
    {
        var result = new List<RelationshipModel>();

        foreach (var chunk in chunks)
        {
            result.AddRange(chunk.BuildRelationshipsForRelatedChunks());
        }

        return [.. result];
    }

    private static List<RelationshipModel> BuildRelationshipsForRelatedChunks(this ChunkModel firstChunk)
    {
        if (firstChunk.RelatedChunksIndexes.Count == 0)
        {
            return [];
        }

        var result = new List<RelationshipModel>();

        foreach (var relationshipType in RelatedChunkTypeSequence)
        {
            var isCurrentChunkFirst = relationshipType != RelationshipType.StartsWith;

            if (firstChunk.RelatedChunksIndexes.TryGetValue(relationshipType, out var indexes))
            {
                result.AddRange(indexes.Select(x => new RelationshipModel
                {
                    FirstChunkIndex = isCurrentChunkFirst ? firstChunk.Index : x,
                    SecondChunkIndex = isCurrentChunkFirst ? x : firstChunk.Index,
                    RelationshipType = relationshipType,
                }));
            }
        }

        return result;
    }
}
