namespace RagDataTools.Chunkers.Strategies.IndexesExtractors;

public interface IPrimitivesIndexesExtractor
{
    public int[] ExtractIndexes(string text);
}
