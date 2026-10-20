using RagDataTools.Chunkers.Models.Enums;

namespace RagDataTools.Chunkers.Models;

/// <summary>
/// Представляет связь между двумя чанками в графе.
/// </summary>
public record RelationshipModel
{
    /// <summary>
    /// Gets or sets индекс первого чанка в связи.
    /// </summary>
    public int FirstChunkIndex { get; set; }

    /// <summary>
    /// Gets or sets индекс второго чанка в связи.
    /// </summary>
    public int SecondChunkIndex { get; set; }

    /// <summary>
    /// Gets or sets тип связи между чанками: следующий, подзаголовок, связанный код и т.д.
    /// </summary>
    public RelationshipType RelationshipType { get; set; }
}
