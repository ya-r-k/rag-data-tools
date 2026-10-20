using RagDataTools.Chunkers.Models;
using RagDataTools.FakeInfrastructure.Models;
using RagDataTools.FakeInfrastructure.SimpleGenerators;

namespace RagDataTools.FakeInfrastructure.DataBuilders;

public class MarkdownDataBuilder(
    Random random,
    ListDataGenerator listDataGenerator,
    TextDataGenerator? textDataGenerator)
{
    protected List<MarkdownData> buildingData = [];

    public string GeneratePlainText(int wordCount)
    {
        return this.BuildMarkdownTextFixtureGenerator().GeneratePlainText(wordCount);
    }

    public string GenerateBenchmarkMarkdownText(int wordCount)
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateBenchmarkMarkdownText(wordCount);
    }

    public string GenerateBenchmarkComplexMarkdownText(int wordCount)
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateBenchmarkComplexMarkdownText(wordCount);
    }

    public string GenerateHeadersMarkdownFixture()
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateHeadersMarkdownFixture();
    }

    public string GenerateInfoBlocksMarkdownFixture()
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateInfoBlocksMarkdownFixture();
    }

    public string GenerateLinksMarkdownFixture()
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateLinksMarkdownFixture();
    }

    public string GenerateImageLinksMarkdownFixture()
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateImageLinksMarkdownFixture();
    }

    public string GenerateTablesMarkdownFixture()
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateTablesMarkdownFixture();
    }

    public string GenerateCodeBlocksMarkdownFixture()
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateCodeBlocksMarkdownFixture();
    }

    public string GenerateMixedRelationsMarkdownFixture()
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateMixedRelationsMarkdownFixture();
    }

    public string GenerateDevToRealWorldArticle()
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateDevToRealWorldArticle();
    }

    public string GenerateArticleWithMathInfoBlocks()
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateArticleWithMathInfoBlocks();
    }

    public string GenerateArticleWithUnusualCodeBlocks()
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateArticleWithUnusualCodeBlocks();
    }

    public string GenerateDataModelingArticle()
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateDataModelingArticle();
    }

    public string GenerateRelationalAlgebraArticle()
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateRelationalAlgebraArticle();
    }

    public string GenerateWikipediaNestedTablesArticle()
    {
        return this.BuildMarkdownTextFixtureGenerator().GenerateWikipediaNestedTablesArticle();
    }

    public List<RelationshipModel> BuildRelationships()
    {
        return [];
    }

    private MarkdownTextFixtureGenerator BuildMarkdownTextFixtureGenerator()
    {
        return new MarkdownTextFixtureGenerator(textDataGenerator ?? new TextDataGenerator(random));
    }
}
