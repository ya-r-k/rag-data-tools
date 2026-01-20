using FluentAssertions;
using Sample.Chunkers.Infrastructure;
using Sample.Chunkers.Strategies.IndexesExtractors;

namespace Sample.Chunkers.UnitTests.Strategies.IndexesExtractors;

public class SentenceIndexesExtractorTests
{
    [Test]
    public void ExtractIndexes()
    {
        // Arrange
        var text = @"Now you know how Qdrant works. Getting started with Qdrant Cloud is just as easy. Create an account and use our SaaS completely free. We will take care of infrastructure maintenance and software updates.

                    To move onto some more complex examples of vector search, read our Tutorials and create your own app with the help of our Examples.

                    Note: There is another way of running Qdrant locally. If you are a Python developer, we recommend that you try Local Mode in Qdrant Client, as it only takes a few moments to get setup.


                    ";

        var expectedResult = new[]
        {
            0, 6, 15, 24, 34, 58, 67, 93
        };

        var regexProvider = new TextChunksRegexProvider();
        var extractor = new SentenceIndexesExtractor(regexProvider);

        // Act
        var actualResult = extractor.ExtractIndexes(text);

        // Assert
        actualResult.Should().BeEquivalentTo(expectedResult);
    }
}
