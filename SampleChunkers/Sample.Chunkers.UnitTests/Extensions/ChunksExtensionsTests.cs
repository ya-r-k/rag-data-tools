using FluentAssertions;
using Sample.Chunkers.Enums;
using Sample.Chunkers.Extensions;
using Sample.Chunkers.Models;
using Sample.Chunkers.UnitTests.TestData;

namespace Sample.Chunkers.UnitTests.Extensions;

public class ChunksExtensionsTests
{
    [Test]
    public void BuildRelationsGraph_WithRealWorldTextWithInfoBlocks_ShouldReturnCorrectHeadersRelations()
    {
        // Arrange
        var text = ArticlesTestData.ArticleWithMathInfoBlocks;
        var expectedTopicsRelations = RelationsTestData.ArticleWithMathInfoBlocks;

        // Act
        var chunks = text.ExtractSemanticChunksDeeply(200, SemanticsType.Sentence, 0.5);
        var relationships = chunks.BuildRelationsGraph();

        // Assert
        relationships.Intersect(expectedTopicsRelations).Should().BeEquivalentTo(expectedTopicsRelations);
    }

    [Test]
    public void BuildRelationsGraph_WithRealWorldText_ShouldReturnCorrectChunksRelations()
    {
        // Arrange
        var text = ArticlesTestData.DevToRealWorldArticleText;
        var expectedResult = RelationsTestData.DevToRealWorldArticleChunksRelations;

        // Act
        var chunks = text.ExtractSemanticChunksDeeply(200, SemanticsType.Sentence, 0.5);
        var relationships = chunks.BuildRelationsGraph();

        // Assert
        relationships.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void BuildRelationsGraph_WithRealWorldSecondText_ShouldReturnCorrectChunksRelations()
    {
        // Arrange
        var text = ArticlesTestData.GeeksForGeeksTextAboutDataModeling;
        var expectedResult = RelationsTestData.GeeksForGeeksAboutDataModelingChunksRelations;

        // Act
        var chunks = text.ExtractSemanticChunksDeeply(200, SemanticsType.Sentence, 0.5);
        var relationships = chunks.BuildRelationsGraph();

        // Assert
        relationships.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void BuildRelationsGraph_WithRealWorldTextsCollection_ShouldReturnCorrectChunksRelations()
    {
        // Arrange
        var texts = new Dictionary<int, string>
        {
            // https://dev.to/alex_ricciardi/recursion-in-programming-techniques-benefits-and-limitations-java-3o4p
            [0] = ArticlesTestData.DevToRealWorldArticleText,
            // https://www.geeksforgeeks.org/data-modeling-a-comprehensive-guide-for-analysts/
            [1] = ArticlesTestData.GeeksForGeeksTextAboutDataModeling,
            // https://www.geeksforgeeks.org/basic-operators-in-relational-algebra-2/
            [2] = ArticlesTestData.GeeksForGeeksTextAboutRelationalAlgebra,
        };

        var secondShiftValue = CodeBlocksTestData.DevToRealWorldArticleCodeBlocks.Length +
                               LinksTestData.DevToRealWorldArticleLinks.Length +
                               TextChunkTestData.DevToRealWorldArticleTextChunks.Length;
        var thirdShiftValue = secondShiftValue +
                              ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks.Length +
                              LinksTestData.GeeksForGeeksAboutDataModelingLinks.Length +
                              HeadersTestData.GeeksForGeeksAboutDataModelingHeaders.Length +
                              TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks.Length;
        var indexShiftValues = new[]
        {
            0,
            secondShiftValue,
            thirdShiftValue,
        };

        var expectedResult = new Dictionary<int, List<RelationshipModel>>
        {
            [0] = RelationsTestData.DevToRealWorldArticleChunksRelations,
            [1] = RelationsTestData.GeeksForGeeksAboutDataModelingChunksRelations,
            [2] = RelationsTestData.GeeksForGeeksAboutRelationalAlgebraChunksRelations,
        }.Select(x => new
        {
            x.Key,
            Value = x.Value.Select(y => new RelationshipModel
            {
                FirstChunkIndex = y.FirstChunkIndex + indexShiftValues[x.Key],
                SecondChunkIndex = y.SecondChunkIndex + indexShiftValues[x.Key],
                RelationshipType = y.RelationshipType,
            }).ToList()
        }).SelectMany(x => x.Value).ToArray();

        // Act
        var chunks = texts.ExtractSemanticChunksDeeply(200, SemanticsType.Sentence, 0.5);
        var relationships = chunks.BuildRelationsGraph();

        // Assert
        relationships.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void FindRepeatedChunksWithUrls_WithRealWorldTextsCollection_ShouldReturnRepeatedAndUniqueIndexesPairs()
    {
        // Arrange
        var texts = new Dictionary<int, string>
        {
            // https://dev.to/alex_ricciardi/recursion-in-programming-techniques-benefits-and-limitations-java-3o4p
            [0] = ArticlesTestData.DevToRealWorldArticleText,
            // https://www.geeksforgeeks.org/data-modeling-a-comprehensive-guide-for-analysts/
            [1] = ArticlesTestData.GeeksForGeeksTextAboutDataModeling,
            // https://www.geeksforgeeks.org/basic-operators-in-relational-algebra-2/
            [2] = ArticlesTestData.GeeksForGeeksTextAboutRelationalAlgebra,
        };

        var secondShiftValue = CodeBlocksTestData.DevToRealWorldArticleCodeBlocks.Length +
                               LinksTestData.DevToRealWorldArticleLinks.Length +
                               TextChunkTestData.DevToRealWorldArticleTextChunks.Length;
        var thirdShiftValue = secondShiftValue +
                              ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks.Length +
                              LinksTestData.GeeksForGeeksAboutDataModelingLinks.Length +
                              HeadersTestData.GeeksForGeeksAboutDataModelingHeaders.Length +
                              TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks.Length;
        var indexShiftValues = new[]
        {
            0,
            secondShiftValue,
            thirdShiftValue,
        };

        var expectedImageLinks = new Dictionary<int, ChunkModel[]>
        {
            [1] = ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks,
            [2] = ImageLinksTestData.GeeksForGeeksAboutRelationalAlgebraImageLinks,
        }.SelectMany(x => x.Value.Select(y => new ChunkModel
        {
            Index = y.Index + indexShiftValues[x.Key],
            ChunkType = y.ChunkType,
            RawContent = y.RawContent,
            RelatedChunksIndexes = y.RelatedChunksIndexes,
            Data = y.Data,
        })).ToArray();
        var expectedLinks = new Dictionary<int, ChunkModel[]>
        {
            [0] = LinksTestData.DevToRealWorldArticleLinks,
            [1] = LinksTestData.GeeksForGeeksAboutDataModelingLinks,
            [2] = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks,
        }.SelectMany(x => x.Value.Select(y => new ChunkModel
        {
            Index = y.Index + indexShiftValues[x.Key],
            ChunkType = y.ChunkType,
            RawContent = y.RawContent,
            RelatedChunksIndexes = y.RelatedChunksIndexes.Select(y => new
            {
                y.Key,
                Value = y.Value.Select(y => y + indexShiftValues[x.Key]).ToList(),
            }).ToDictionary(x => x.Key, x => x.Value),
            Data = y.Data,
        })).ToArray();

        var expectedPairs = new Dictionary<int, int>
        {
            [expectedImageLinks[4].Index] = expectedImageLinks[0].Index,
            [expectedImageLinks[5].Index] = expectedImageLinks[0].Index,
            [expectedImageLinks[7].Index] = expectedImageLinks[0].Index,
            [expectedLinks[17].Index] = expectedLinks[1].Index,
            [expectedLinks[20].Index] = expectedLinks[1].Index,
            [expectedLinks[30].Index] = expectedLinks[1].Index,
            [expectedLinks[27].Index] = expectedLinks[12].Index,
            [expectedLinks[14].Index] = expectedLinks[13].Index,
            [expectedLinks[16].Index] = expectedLinks[15].Index,
            [expectedLinks[29].Index] = expectedLinks[28].Index,
        };

        // Act
        var chunks = texts.ExtractSemanticChunksDeeply(200, SemanticsType.Sentence, 0.5);
        var pairs = chunks.FindRepeatedChunksWithUrls();

        // Assert
        pairs.Should().BeEquivalentTo(expectedPairs);
    }
}
