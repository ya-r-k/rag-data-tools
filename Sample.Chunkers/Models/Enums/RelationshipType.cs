namespace Sample.Chunkers.Models.Enums;

public enum RelationshipType
{
    Unknown = 0,
    StartsWith = 1,
    RelatedCodeBlock = 2,
    RelatedImage = 3,
    RelatedTable = 4,
    RelatedInfoBlock = 5,
    RelatedMathBlock = 6,
    AdditionalLink = 7,
    HasNextTopic = 8,
    HasFirstSubtopic = 9,
    HasNextChunk = 10,
    LoadedFrom = 11,
}
