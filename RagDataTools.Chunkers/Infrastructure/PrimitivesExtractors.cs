using RagDataTools.Chunkers.Strategies.IndexesExtractors;

namespace RagDataTools.Chunkers.Infrastructure;

public static class PrimitivesExtractors
{
    private static readonly TextChunksRegexProvider regexProvider = new();

    public static readonly IPrimitivesIndexesExtractor WordsExtractor = new WordsIndexesExtractor(regexProvider);

    public static readonly IPrimitivesIndexesExtractor SentencesExtractor = new SentenceIndexesExtractor(regexProvider);

    public static readonly IPrimitivesIndexesExtractor ParagraphsExtractor = new ParagraphIndexesExtractor(regexProvider);
}
