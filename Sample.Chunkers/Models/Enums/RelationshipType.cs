namespace Sample.Chunkers.Models.Enums;

public enum RelationshipType
{
    Unknown = 0,
    StartsWith = 1,
    RelatedCodeBlock = 2,
    RelatedImage = 3,
    RelatedTable = 4,
    RelatedInfoBlock = 5,
    AdditionalLink = 6,
    HasNextTopic = 7,
    HasFirstSubtopic = 8,
    HasNextChunk = 9,
    LoadedFrom = 10,
}
