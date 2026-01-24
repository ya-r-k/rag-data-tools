using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using RagDataTools.Chunkers.Extensions;
using RagDataTools.Chunkers.Infrastructure;
using System.Text;

namespace RagDataTools.Benchmarks;

/// <summary>
/// Бенчмарки для основных методов библиотеки Sample.Chunkers.
/// </summary>
[SimpleJob(RuntimeMoniker.Net90)]
[MemoryDiagnoser]
[MarkdownExporter]
public class ChunkersBenchmarks
{
    // Тестовые данные различного размера
    private readonly string _smallText;
    private readonly string _mediumText;
    private readonly string _largeText;
    private readonly string _veryLargeText;
    private readonly string _markdownText;
    private readonly string _complexMarkdownText;

    public ChunkersBenchmarks()
    {
        // Маленький текст (~100 слов)
        _smallText = GenerateText(100);

        // Средний текст (~1000 слов)
        _mediumText = GenerateText(1000);

        // Большой текст (~10000 слов)
        _largeText = GenerateText(10000);

        // Очень большой текст (~100000 слов)
        _veryLargeText = GenerateText(100000);

        // Markdown текст
        _markdownText = GenerateMarkdownText(1000);

        // Сложный Markdown с множеством элементов
        _complexMarkdownText = GenerateComplexMarkdownText(5000);
    }

    #region SimpleTextChunkerExtensions

    [Benchmark(Baseline = true)]
    public void ExtractSemanticChunksFromText_Small()
    {
        var text = GenerateText(100);
        _ = text.ExtractSemanticChunksFromText(50, PrimitivesExtractors.SentencesExtractor, 0.0);
    }

    [Benchmark]
    public void ExtractSemanticChunksFromText_Medium_Sentence()
    {
        _ = _mediumText.ExtractSemanticChunksFromText(200, PrimitivesExtractors.SentencesExtractor, 0.5);
    }

    [Benchmark]
    public void ExtractSemanticChunksFromText_Medium_Paragraph()
    {
        _ = _mediumText.ExtractSemanticChunksFromText(200, PrimitivesExtractors.ParagraphsExtractor, 0.5);
    }

    [Benchmark]
    public void ExtractSemanticChunksFromText_Large_Sentence()
    {
        _ = _largeText.ExtractSemanticChunksFromText(200, PrimitivesExtractors.SentencesExtractor, 0.3);
    }

    [Benchmark]
    public void ExtractSemanticChunksFromText_Large_Paragraph()
    {
        _ = _largeText.ExtractSemanticChunksFromText(200, PrimitivesExtractors.ParagraphsExtractor, 0.3);
    }

    [Benchmark]
    public void ExtractSemanticChunksFromText_VeryLarge()
    {
        _ = _veryLargeText.ExtractSemanticChunksFromText(200, PrimitivesExtractors.SentencesExtractor, 0.5);
    }

    [Benchmark]
    public void PreprocessNaturalTextForChunking_Small()
    {
        _ = _smallText.PreprocessNaturalTextForChunking();
    }

    [Benchmark]
    public void PreprocessNaturalTextForChunking_Medium()
    {
        _ = _mediumText.PreprocessNaturalTextForChunking();
    }

    [Benchmark]
    public void PreprocessNaturalTextForChunking_Large()
    {
        _ = _largeText.PreprocessNaturalTextForChunking();
    }

    [Benchmark]
    public void GetWords_Small()
    {
        _ = PrimitivesExtractors.WordsExtractor.ExtractIndexes(_smallText);
    }

    [Benchmark]
    public void GetWords_Large()
    {
        _ = PrimitivesExtractors.WordsExtractor.ExtractIndexes(_largeText);
    }

    [Benchmark]
    public void ExtractSentenceStartIndices()
    {
        _ = PrimitivesExtractors.SentencesExtractor.ExtractIndexes(_mediumText);
    }

    [Benchmark]
    public void ExtractParagraphStartIndexes()
    {
        _ = PrimitivesExtractors.ParagraphsExtractor.ExtractIndexes(_mediumText);
    }

    #endregion

    #region ComplexDataChunkerExtensions

    [Benchmark]
    public void ExtractSemanticChunksDeeply_PlainText()
    {
        _ = _mediumText.ExtractSemanticChunksDeeply(
            200,
            PrimitivesExtractors.SentencesExtractor,
            0.5
        );
    }

    [Benchmark]
    public void ExtractSemanticChunksDeeply_MarkdownSimple()
    {
        _ = _markdownText.ExtractSemanticChunksDeeply(
            200,
            PrimitivesExtractors.SentencesExtractor,
            0.5
        );
    }

    [Benchmark]
    public void ExtractSemanticChunksDeeply_MarkdownComplex()
    {
        _ = _complexMarkdownText.ExtractSemanticChunksDeeply(
            200,
            PrimitivesExtractors.SentencesExtractor,
            0.5
        );
    }
    #endregion

    #region ChunksExtensions

    [Benchmark]
    public void BuildRelationsGraph_Medium()
    {
        var chunks = _mediumText.ExtractSemanticChunksDeeply(200, PrimitivesExtractors.SentencesExtractor, 0.5);
        _ = chunks.BuildRelationsGraph();
    }

    [Benchmark]
    public void BuildRelationsGraph_Complex()
    {
        var chunks = _complexMarkdownText.ExtractSemanticChunksDeeply(200, PrimitivesExtractors.SentencesExtractor, 0.5);
        _ = chunks.BuildRelationsGraph();
    }

    [Benchmark]
    public void FindRepeatedChunksWithUrls()
    {
        var documents = new Dictionary<int, string>
        {
            [0] = _markdownText,
            [1] = _complexMarkdownText
        };

        var chunks = documents.ExtractSemanticChunksDeeply(200, PrimitivesExtractors.SentencesExtractor, 0.5);
        _ = chunks.FindRepeatedChunksWithUrls();
    }

    #endregion

    #region Helper Methods

    private static string GenerateText(int wordCount)
    {
        var words = new[] { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog", ".", "This", "is", "a", "sample", "sentence", "with", "multiple", "words", "and", "punctuation", "marks", "!", "How", "about", "questions", "?" };
        var random = new Random(42);
        var sb = new StringBuilder();

        for (int i = 0; i < wordCount; i++)
        {
            sb.Append(words[random.Next(words.Length)]);
            if (i < wordCount - 1)
            {
                sb.Append(' ');
            }
        }

        return sb.ToString();
    }

    private static string GenerateMarkdownText(int wordCount)
    {
        var words = new[] { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog", ".", "This", "is", "a", "sample", "sentence", "with", "multiple", "words", "and", "punctuation", "marks", "!", "How", "about", "questions", "?" };
        var random = new Random(42);
        var sb = new StringBuilder();

        sb.AppendLine("# Main Title");
        sb.AppendLine();

        var paragraphs = 10;
        var wordsPerParagraph = wordCount / paragraphs;

        for (int p = 0; p < paragraphs; p++)
        {
            if (p % 2 == 0)
            {
                sb.AppendLine($"## Subtitle {p + 1}");
                sb.AppendLine();
            }

            for (int i = 0; i < wordsPerParagraph; i++)
            {
                sb.Append(words[random.Next(words.Length)]);
                if (i < wordsPerParagraph - 1)
                {
                    sb.Append(' ');
                }
            }

            sb.AppendLine();
            sb.AppendLine();
        }

        return sb.ToString();
    }

    private static string GenerateComplexMarkdownText(int wordCount)
    {
        var words = new[] { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog", ".", "This", "is", "a", "sample", "sentence", "with", "multiple", "words", "and", "punctuation", "marks", "!", "How", "about", "questions", "?" };
        var random = new Random(42);
        var sb = new StringBuilder();

        sb.AppendLine("# Main Title");
        sb.AppendLine();
        sb.AppendLine("## First Section");
        sb.AppendLine();

        var paragraphs = 20;
        var wordsPerParagraph = wordCount / paragraphs;

        for (int p = 0; p < paragraphs; p++)
        {
            if (p % 3 == 0)
            {
                sb.AppendLine($"### Subsection {p / 3 + 1}");
                sb.AppendLine();
            }

            if (p % 5 == 0)
            {
                sb.AppendLine("```csharp");
                sb.AppendLine("var code = \"example\";");
                sb.AppendLine("Console.WriteLine(code);");
                sb.AppendLine("```");
                sb.AppendLine();
            }

            if (p % 7 == 0)
            {
                sb.AppendLine("<table>");
                sb.AppendLine("    <tr><td>Cell 1</td><td>Cell 2</td></tr>");
                sb.AppendLine("    <tr><td>Cell 3</td><td>Cell 4</td></tr>");
                sb.AppendLine("</table>");
                sb.AppendLine();
            }

            if (p % 11 == 0)
            {
                sb.AppendLine("> This is an info block");
                sb.AppendLine("> with multiple lines");
                sb.AppendLine();
            }

            if (p % 13 == 0)
            {
                sb.AppendLine("![Image](https://example.com/image.jpg)");
                sb.AppendLine();
            }

            if (p % 17 == 0)
            {
                sb.AppendLine("[Link](https://example.com)");
                sb.AppendLine();
            }

            for (int i = 0; i < wordsPerParagraph; i++)
            {
                sb.Append(words[random.Next(words.Length)]);
                if (i < wordsPerParagraph - 1)
                {
                    sb.Append(' ');
                }
            }

            sb.AppendLine();
            sb.AppendLine();
        }

        return sb.ToString();
    }

    #endregion
}

