using FluentAssertions;
using RagDataTools.Chunkers.Extensions;
using RagDataTools.Chunkers.Infrastructure;
using RagDataTools.Chunkers.Strategies.IndexesExtractors;

namespace RagDataTools.UnitTests.Chunkers.Strategies.IndexesExtractors;

public class WordIndexesExtractorTests
{
    [Test]
    public void ExtractIndexes_WhenTextContainsSingleParagraph()
    {
        // Arrange
        var text = @"Now you know how Qdrant works. Getting started with Qdrant Cloud is just as easy.";
        var expectedResult = new[]
        {
            0, 4, 8, 13, 17, 24,
            31, 39, 47, 52, 59, 65,
            68, 73, 76
        };
        /*var expectedResult = new string[]
        {
            "Now", "you", "know", "how", "Qdrant", "works.",
            "Getting", "started", "with", "Qdrant", "Cloud",
            "is", "just", "as", "easy."
        };*/

        var regexProvider = new TextChunksRegexProvider();
        var extractor = new WordsIndexesExtractor(regexProvider);

        // Act
        var actualResult = extractor.ExtractIndexes(text.PreprocessNaturalTextForChunking());

        // Assert
        actualResult.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void ExtractIndexes_WhenTextContainsMultipleParagraphs()
    {
        // Arrange
        var text = @"We will take care of infrastructure maintenance and software updates.

                     To move onto some more complex examples of vector search, read our Tutorials and create your own app with the help of our Examples.";
        var expectedResult = new[]
        {
            0, 3, 8, 13, 18, 21,
            36, 48, 52, 61, 73, 76,
            81, 86, 91, 96, 104, 113,
            116, 123, 131, 136, 140, 150,
            154, 161, 166, 170, 174, 179,
            183, 188, 191, 195
        };
        /*var expectedResult = new string[]
        {
            "We", "will", "take", "care", "of", "infrastructure", "maintenance", "and", "software", "updates.\n\n",
            "To", "move", "onto", "some", "more", "complex", "examples", "of", "vector", "search,",
            "read", "our", "Tutorials", "and", "create", "your", "own", "app", "with", "the",
            "help", "of", "our", "Examples."
        };*/

        var regexProvider = new TextChunksRegexProvider();
        var extractor = new WordsIndexesExtractor(regexProvider);

        // Act
        var actualResult = extractor.ExtractIndexes(text.PreprocessNaturalTextForChunking());

        // Assert
        actualResult.Should().BeEquivalentTo(expectedResult);
    }
}
