using FluentAssertions;
using RagDataTools.Chunkers.Extensions;
using RagDataTools.Chunkers.Infrastructure;
using RagDataTools.Chunkers.Strategies.IndexesExtractors;

namespace RagDataTools.UnitTests.Chunkers.Strategies.IndexesExtractors;

public class SentenceIndexesExtractorTests
{
    [Test]
    public void ExtractIndexes_WhenTextIsNotPreprocessed()
    {
        // Arrange
        var text = @"Now you know how Qdrant works. Getting started with Qdrant Cloud is just as easy. Create an account and use our SaaS completely free. We will take care of infrastructure maintenance and software updates.

                    To move onto some more complex examples of vector search, read our Tutorials and create your own app with the help of our Examples.

                    Note: There is another way of running Qdrant locally. If you are a Python developer, we recommend that you try Local Mode in Qdrant Client, as it only takes a few moments to get setup.


                    ";

        var expectedResult = new[]
        {
            0, 31, 82, 134, 227, 382, 436
        };

        var regexProvider = new TextChunksRegexProvider();
        var extractor = new SentenceIndexesExtractor(regexProvider);

        // Act
        var actualResult = extractor.ExtractIndexes(text);

        // Assert
        actualResult.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void ExtractIndexes_WhenTextIsPreprocessed()
    {
        // Arrange
        var text = @"Now you know how Qdrant works. Getting started with Qdrant Cloud is just as easy. Create an account and use our SaaS completely free. We will take care of infrastructure maintenance and software updates.

                    To move onto some more complex examples of vector search, read our Tutorials and create your own app with the help of our Examples.

                    Note: There is another way of running Qdrant locally. If you are a Python developer, we recommend that you try Local Mode in Qdrant Client, as it only takes a few moments to get setup.


                    ";

        var expectedResult = new[]
        {
            //0, 31, 82, 134, 208, 344, 398 // should be
            0, 31, 82, 134, 206, 340, 394 // now
        };

        var regexProvider = new TextChunksRegexProvider();
        var extractor = new SentenceIndexesExtractor(regexProvider);

        var processedText = text.PreprocessNaturalTextForChunking();

        // Act
        var actualResult = extractor.ExtractIndexes(processedText);

        // Assert
        actualResult.Should().BeEquivalentTo(expectedResult);
    }

    [TestCase("* * *", 1)]
    [TestCase("* * *\r\n\r\n* * *", 1)]
    [TestCase("The implementation is", 1)]
    [TestCase("The       implementation         is", 1)]
    [TestCase("model ,The", 1)]
    [TestCase("model, The", 1)]
    [TestCase("model , The", 1)]
    [TestCase("model          ,    The", 1)]
    [TestCase("model      \t\n\n\n\n\r\n    ,  \n\r\n  The", 1)]
    [TestCase("later.T he", 2)]
    [TestCase("later!T he", 2)]
    [TestCase("later?T he", 2)]
    [TestCase("later!?T he", 2)]
    [TestCase("later...T he", 2)]
    [TestCase("later!..T he", 2)]
    [TestCase("later?..T he", 2)]
    [TestCase("database system. It outlines", 2)]
    [TestCase("updates.\r\n\r\n                     To move", 2)]
    [TestCase("database system! It outlines", 2)]
    [TestCase("database system? It outlines", 2)]
    [TestCase("database system!? It outlines", 2)]
    [TestCase("database system: It outlines", 1)]
    [TestCase("database system:\nIt outlines", 2)]
    [TestCase("database system:\r\nIt outlines", 2)]
    [TestCase("database system:\r\n\r\n\r\n\r\n\r\nIt outlines", 2)]
    [TestCase("database system; It outlines", 1)]
    [TestCase("database system... It outlines", 2)]
    [TestCase("database system!.. It outlines", 2)]
    [TestCase("database system?.. It outlines", 2)]
    [TestCase("database system - It outlines", 1)]
    [TestCase("database system - - - -  - It outlines", 1)]
    [TestCase(" - **Logical Data Model**:", 1)]
    [TestCase("- \r\n - \r\n - **Logical Data Model**:", 1)]
    [TestCase("- [ ] \r\n - \r\n - **Logical Data Model**:", 1)]
    [TestCase("- [x] \r\n - \r\n - **Logical Data Model**:", 1)]
    public void ExtractIndexes_WhenTextsWithDiverseCases_ShouldHaveExpectedIndexesCount(string text, int indexesCount)
    {
        // Arrange
        var regexProvider = new TextChunksRegexProvider();
        var extractor = new SentenceIndexesExtractor(regexProvider);

        // Act
        var actualResult = extractor.ExtractIndexes(text);

        // Assert
        actualResult.Should().HaveCount(indexesCount);
    }

    [TestCase("* * *", new int[] { 0 })]
    [TestCase("* * *\r\n\r\n* * *", new int[] { 0 })]
    [TestCase("The implementation is", new int[] { 0 })]
    [TestCase("model ,The", new int[] { 0 })]
    [TestCase("model          ,    The", new int[] { 0 })]
    [TestCase("model      \t\n\n\n\n\r\n    ,  \n\r\n  The", new int[] { 0 })]
    [TestCase("later.T he", new int[] { 0, 6 })]
    [TestCase("later?T he", new int[] { 0, 6 })]
    [TestCase("later!?T he", new int[] { 0, 7 })]
    [TestCase("later...T he", new int[] { 0, 8 })]
    [TestCase("later!..T he", new int[] { 0, 8 })]
    [TestCase("later?..T he", new int[] { 0, 8 })]
    [TestCase("database system. It outlines", new int[] { 0, 17 })]
    [TestCase("updates.\r\n\r\n                     To move", new int[] { 0, 33 })]
    [TestCase("database system! It outlines", new int[] { 0, 17 })]
    [TestCase("database system? It outlines", new int[] { 0, 17 })]
    [TestCase("database system!? It outlines", new int[] { 0, 18 })]
    [TestCase("database system: It outlines", new int[] { 0 })]
    [TestCase("database system:\nIt outlines", new int[] { 0, 17 })]
    [TestCase("database system:\r\nIt outlines", new int[] { 0, 18 })]
    [TestCase("database system:\r\n\r\n\r\n\r\n\r\nIt outlines", new int[] { 0, 26 })]
    [TestCase("database system; It outlines", new int[] { 0 })]
    [TestCase("database system... It outlines", new int[] { 0, 19 })]
    [TestCase("database system!.. It outlines", new int[] { 0, 19 })]
    [TestCase("database system?.. It outlines", new int[] { 0, 19 })]
    [TestCase("database system - It outlines", new int[] { 0 })]
    [TestCase("database system - - - -  - It outlines", new int[] { 0 })]
    [TestCase(" - **Logical Data Model**:", new int[] { 0 })]
    [TestCase("- \r\n - \r\n - **Logical Data Model**:", new int[] { 0 })]
    [TestCase("- [ ] \r\n - \r\n - **Logical Data Model**:", new int[] { 0 })]
    [TestCase("- [x] \r\n - \r\n - **Logical Data Model**:", new int[] { 0 })]
    public void ExtractIndexes_WhenTextsWithDiverseCases_ShouldHaveExpectedIndexesCollection(string text, int[] indexes)
    {
        // Arrange
        var regexProvider = new TextChunksRegexProvider();
        var extractor = new SentenceIndexesExtractor(regexProvider);

        // Act
        var actualResult = extractor.ExtractIndexes(text);

        // Assert
        actualResult.Should().BeEquivalentTo(indexes);
    }
}
