using FluentAssertions;
using RagDataTools.Chunkers.Extensions;
using RagDataTools.Chunkers.Infrastructure;
using RagDataTools.Chunkers.Strategies.IndexesExtractors;

namespace RagDataTools.UnitTests.Chunkers.Strategies.IndexesExtractors;

public class WordIndexesExtractorTests
{
    [Test]
    public void ExtractIndexes_WhenTextContainsSingleParagraphAndTextIsPreprocessed()
    {
        // Arrange
        var text = @"Now you know how Qdrant works. Getting started with Qdrant Cloud is just as easy.";
        var expectedResult = new[]
        {
            0, 4, 8, 13, 17, 24,
            31, 39, 47, 52, 59, 65,
            68, 73, 76
        };

        var regexProvider = new TextChunksRegexProvider();
        var extractor = new WordsIndexesExtractor(regexProvider);

        // Act
        var actualResult = extractor.ExtractIndexes(text.PreprocessNaturalTextForChunking());

        // Assert
        actualResult.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void ExtractIndexes_WhenTextContainsSingleParagraphAndTextIsNotPreprocessed()
    {
        // Arrange
        var text = @"Now you know how Qdrant works. Getting started with Qdrant Cloud is just as easy.";
        var expectedResult = new[]
        {
            0, 4, 8, 13, 17, 24,
            31, 39, 47, 52, 59, 65,
            68, 73, 76
        };

        var regexProvider = new TextChunksRegexProvider();
        var extractor = new WordsIndexesExtractor(regexProvider);

        // Act
        var actualResult = extractor.ExtractIndexes(text);

        // Assert
        actualResult.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void ExtractIndexes_WhenTextContainsMultipleParagraphsAndTextIsPreprocessed()
    {
        // Arrange
        var text = @"We will take care of infrastructure maintenance and software updates.

                     To move onto some more complex examples of vector search, read our Tutorials and create your own app with the help of our Examples.";
        var expectedResult = new[]
        {
            0, 3, 8, 13, 18, 21,
            36, 48, 52, 61, 72, 75,
            80, 85, 90, 95, 103, 112,
            115, 122, 130, 135, 139, 149,
            153, 160, 165, 169, 173, 178,
            182, 187, 190, 194
        };

        var regexProvider = new TextChunksRegexProvider();
        var extractor = new WordsIndexesExtractor(regexProvider);

        // Act
        var actualResult = extractor.ExtractIndexes(text.PreprocessNaturalTextForChunking());

        // Assert
        actualResult.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void ExtractIndexes_WhenTextContainsMultipleParagraphsAndTextIsNotPreprocessed()
    {
        // Arrange
        var text = @"We will take care of infrastructure maintenance and software updates.

                     To move onto some more complex examples of vector search, read our Tutorials and create your own app with the help of our Examples.";
        var expectedResult = new[]
        {
            0, 3, 8, 13, 18, 21,
            36, 48, 52, 61, 94, 97,
            102, 107, 112, 117, 125, 134,
            137, 144, 152, 157, 161, 171,
            175, 182, 187, 191, 195, 200, 204,
            209, 212, 216
        };

        var regexProvider = new TextChunksRegexProvider();
        var extractor = new WordsIndexesExtractor(regexProvider);

        // Act
        var actualResult = extractor.ExtractIndexes(text);

        // Assert
        actualResult.Should().BeEquivalentTo(expectedResult);
    }

    [TestCase("* * *", 1)]
    [TestCase("* * *\r\n\r\n* * *", 1)]
    [TestCase("The implementation is", 3)]
    [TestCase("The       implementation         is", 3)]
    [TestCase("model ,The", 2)]
    [TestCase("model, The", 2)]
    [TestCase("model , The", 2)]
    [TestCase("model          ,    The", 2)]
    [TestCase("model      \t\n\n\n\n\r\n    ,  \n\r\n  The", 2)]
    [TestCase("later.T he", 3)]
    [TestCase("database system. It outlines", 4)]
    [TestCase("updates.\r\n\r\n                     To move", 3)]
    [TestCase("database system! It outlines", 4)]
    [TestCase("database system? It outlines", 4)]
    [TestCase("database system!? It outlines", 4)]
    [TestCase("database system: It outlines", 4)]
    [TestCase("database system; It outlines", 4)]
    [TestCase("database system... It outlines", 4)]
    [TestCase("database system!.. It outlines", 4)]
    [TestCase("database system?.. It outlines", 4)]
    [TestCase("database system - It outlines", 4)]
    [TestCase("database system - - - -  - It outlines", 4)]
    [TestCase(" - **Logical Data Model**:", 3)]
    [TestCase("- \r\n - \r\n - **Logical Data Model**:", 3)]
    [TestCase("- [ ] \r\n - \r\n - **Logical Data Model**:", 3)]
    [TestCase("- [x] \r\n - \r\n - **Logical Data Model**:", 3)]
    public void ExtractIndexes_WhenTextsWithDiverseCases_ShouldHaveExpectedIndexesCount(string text, int indexesCount)
    {
        // Arrange
        var regexProvider = new TextChunksRegexProvider();
        var extractor = new WordsIndexesExtractor(regexProvider);

        // Act
        var actualResult = extractor.ExtractIndexes(text);

        // Assert
        actualResult.Should().HaveCount(indexesCount);
    }

    [TestCase("* * *", new int[] { 0 })]
    [TestCase("* * *\r\n\r\n* * *", new int[] { 0 })]
    [TestCase("The implementation is", new int[] { 0, 4, 19 })]
    [TestCase("model ,The", new int[] { 0, 7 })]
    [TestCase("model          ,    The", new int[] { 0, 20 })]
    [TestCase("model      \t\n\n\n\n\r\n    ,  \n\r\n  The", new int[] { 0, 30 })]
    [TestCase("later.T he", new int[] { 0, 6, 8 })]
    [TestCase("database system. It outlines", new int[] { 0, 9, 17, 20 })]
    [TestCase("updates.\r\n\r\n                     To move", new int[] { 0, 33, 36 })]
    [TestCase("database system! It outlines", new int[] { 0, 9, 17, 20 })]
    [TestCase("database system? It outlines", new int[] { 0, 9, 17, 20 })]
    [TestCase("database system!? It outlines", new int[] { 0, 9, 18, 21 })]
    [TestCase("database system: It outlines", new int[] { 0, 9, 17, 20 })]
    [TestCase("database system; It outlines", new int[] { 0, 9, 17, 20 })]
    [TestCase("database system... It outlines", new int[] { 0, 9, 19, 22 })]
    [TestCase("database system!.. It outlines", new int[] { 0, 9, 19, 22 })]
    [TestCase("database system?.. It outlines", new int[] { 0, 9, 19, 22 })]
    [TestCase("database system - It outlines", new int[] { 0, 9, 16, 21 })]
    [TestCase("database system - - - -  - It outlines", new int[] { 0, 9, 16, 30})]
    [TestCase(" - **Logical Data Model**:", new int[] { 0, 12, 17 })]
    [TestCase("- \r\n - \r\n - **Logical Data Model**:", new int[] { 0, 22, 27 })]
    [TestCase("- [ ] \r\n - \r\n - **Logical Data Model**:", new int[] { 0, 26, 31 })]
    [TestCase("- [x] \r\n - \r\n - **Logical Data Model**:", new int[] { 0, 26, 31 })]
    public void ExtractIndexes_WhenTextsWithDiverseCases_ShouldHaveExpectedIndexesCollection(string text, int[] indexes)
    {
        // Arrange

        var regexProvider = new TextChunksRegexProvider();
        var extractor = new WordsIndexesExtractor(regexProvider);

        // Act
        var actualResult = extractor.ExtractIndexes(text);

        // Assert
        actualResult.Should().BeEquivalentTo(indexes);
    }
}
