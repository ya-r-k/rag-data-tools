using RagDataTools.Chunkers.Models.Enums;

namespace RagDataTools.Chunkers.Models;

/// <summary>
/// Представляет один чанк (фрагмент) текста или структурированного элемента.
/// </summary>
public record ChunkModel
{
    /// <summary>
    /// Gets or sets уникальный числовой идентификатор чанка в рамках обработки.
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// Gets or sets тип чанка: текст, код, таблица, заголовок и т.д.
    /// </summary>
    public required ChunkType ChunkType { get; set; }

    /// <summary>
    /// Gets or sets исходное содержимое чанка из документа.
    /// </summary>
    public required string RawContent { get; set; }

    /// <summary>
    /// Gets or sets словарь с дополнительными метаданными чанка (зависит от типа).
    /// Для CodeBlock: language, content.
    /// Для Topic: name, level.
    /// Для ImageLink/AdditionalLink: url, alterText.
    /// Для TextChunk: content.
    /// Для Table/InfoBlock: content.
    /// Для ingest/persistence: page_number, keywords, scope_id, order, heading_level.
    /// </summary>
    public required Dictionary<string, object> Data { get; set; }

    /// <summary>
    /// Gets or sets словарь, связывающий типы связанных чанков с их индексами.
    /// Ключ - тип связанного чанка, значение - список индексов связанных чанков.
    /// </summary>
    public required Dictionary<RelationshipType, List<int>> RelatedChunksIndexes { get; set; }
}
