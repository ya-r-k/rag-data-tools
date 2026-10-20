using RagDataTools.Chunkers.Strategies.IndexesExtractors;

namespace RagDataTools.Chunkers.Infrastructure;

public static class PrimitivesExtractors
{
    private static readonly TextChunksRegexProvider RegexProvider = new ();

    public static readonly IPrimitivesIndexesExtractor WordsExtractor = new WordsIndexesExtractor(RegexProvider);

    public static readonly IPrimitivesIndexesExtractor SentencesExtractor = new SentenceIndexesExtractor(RegexProvider);

    public static readonly IPrimitivesIndexesExtractor ParagraphsExtractor = new ParagraphIndexesExtractor(RegexProvider);
}
