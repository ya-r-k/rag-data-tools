using FluentAssertions;
using RagDataTools.Chunkers.Extensions;
using RagDataTools.Chunkers.Infrastructure;
using RagDataTools.Chunkers.Strategies.IndexesExtractors;

namespace RagDataTools.UnitTests.Chunkers.Strategies.IndexesExtractors;

public class ParagraphIndexesExtractorTests
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
            0, 227, 382,
        };

        var regexProvider = new TextChunksRegexProvider();
        var extractor = new ParagraphIndexesExtractor(regexProvider);

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
            //0, 208, 344, // should be
            0, 206, 340 // now
        };

        var regexProvider = new TextChunksRegexProvider();
        var extractor = new ParagraphIndexesExtractor(regexProvider);

        var processedText = text.PreprocessNaturalTextForChunking();

        // Act
        var actualResult = extractor.ExtractIndexes(processedText);

        // Assert
        actualResult.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void ExtractIndexes_WhenTextWithListItemsAndUnnamedHeadingsAndTextIsNotPreprocessed()
    {
        // Arrange
        var text = @"* * *

* * * They are typically developed as alternatives or preludes to the logical data models that come later.T he main purpose of this data model is to organize, define business problems , rules and concepts.
 - **Logical Data Model**: In the logical data model, By offering a thorough representation of the data at a logical level, the logical data model expands on the conceptual model.It outlines the tables, columns, connections, and constraints that make up thedata structure.
 - **Physical Data Model**: In Physical Data model ,The implementation is explained with reference to a particular database system. It outlines every part and service needed to construct a database.

";
        var expectedResult = new[]
        {
            0, 217, 491,
        };

        var regexProvider = new TextChunksRegexProvider();
        var extractor = new ParagraphIndexesExtractor(regexProvider);

        // Act
        var actualResult = extractor.ExtractIndexes(text);

        // Assert
        actualResult.Should().BeEquivalentTo(expectedResult);
    }
}
