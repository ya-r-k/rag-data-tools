using Sample.Chunkers.Models.Enums;

namespace Sample.Chunkers.Models;

/// <summary>
/// Представляет один чанк (фрагмент) текста или структурированного элемента.
/// </summary>
public record ChunkModel
{
    /// <summary>
    /// Уникальный числовой идентификатор чанка в рамках обработки.
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// Тип чанка: текст, код, таблица, заголовок и т.д.
    /// </summary>
    public required ChunkType ChunkType { get; set; }

    /// <summary>
    /// Исходное содержимое чанка из документа.
    /// </summary>
    public required string RawContent { get; set; }

    /// <summary>
    /// Словарь с дополнительными метаданными чанка (зависит от типа).
    /// Для CodeBlock: language, content.
    /// Для Topic: name, level.
    /// Для ImageLink/AdditionalLink: url, alterText.
    /// Для TextChunk: content.
    /// Для Table/InfoBlock: content.
    /// </summary>
    public required Dictionary<string, object> Data { get; set; }

    /// <summary>
    /// Словарь, связывающий типы связанных чанков с их индексами.
    /// Ключ - тип связанного чанка, значение - список индексов связанных чанков.
    /// </summary>
    public required Dictionary<RelationshipType, List<int>> RelatedChunksIndexes { get; set; }
}
