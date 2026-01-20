using Sample.Chunkers.Strategies.IndexesExtractors;

namespace Sample.Chunkers.Infrastructure;

public static class PrimitivesExtractors
{
    private static readonly TextChunksRegexProvider regexProvider = new();

    public static readonly IPrimitivesIndexesExtractor SentencesExtractor = new SentenceIndexesExtractor(regexProvider);

    public static readonly IPrimitivesIndexesExtractor ParagraphsExtractor = new ParagraphIndexesExtractor();
}
