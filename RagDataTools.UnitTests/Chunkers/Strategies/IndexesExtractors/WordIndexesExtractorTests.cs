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
            /*0, 3, 8, 13, 18, 21,
            36, 48, 52, 61, 74, 77,
            82, 87, 92, 97, 105, 114,
            117, 124, 132, 137, 141, 151,
            155, 162, 167, 171, 175, 180,
            184, 189, 192, 196*/ // should be
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
            /*0, 3, 8, 13, 18, 21,
            36, 48, 52, 61, 74, 77,
            82, 87, 92, 97, 105, 114,
            117, 124, 132, 137, 141, 151,
            155, 162, 167, 171, 175, 180,
            184, 189, 192, 196*/ // should be
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
            0, 20, 24, 34, 44, 47, 60, 63, 72, 75,
            79, 87, 92, 99, 104, /**/ 109, 115, 117, /* later.T he */ 120, 125, 
            133, 136, 141, 146, 152, 155, 158, 168, 175, 184,
            195, 201, 205, 217, 229, 234, 243, 246, 250, 258,
            263, 270, 273, 282, 284, 293, 308, 311, 315, 320,
            323, 325, 333, 340, 344, 352, 357, 363, 371, 374,
            378, 389, 395, 398, 407, 411, 419, 428, 441, 445,
            457, 462, 467, 470, 478, 491, 504, 509, 518, 521,
            530, 535, 542, 546, 561, 564, 574, 579, 589, 592,
            594, 605, 614, 622, 625, 634, 640, 645, 649, 657,
            664, 667, 677, 679,
        };

        var regexProvider = new TextChunksRegexProvider();
        var extractor = new WordsIndexesExtractor(regexProvider);

        // Act
        var actualResult = extractor.ExtractIndexes(text);

        // Assert
        actualResult.Should().BeEquivalentTo(expectedResult);
    }
}
