using FluentAssertions;
using Sample.Chunkers.Enums;
using Sample.Chunkers.Extensions;
using Sample.Chunkers.Models;
using Sample.Chunkers.UnitTests.TestData;

namespace Sample.Chunkers.UnitTests.Extensions;

public class ComplexDataChunkerExtensionsTests
{
    // TODO: Need to add tests which chunks text without codeblocks, tables, links and other related chunks only plain text

    [Test]
    public void RetrieveChunksFromText_WithMixedContent_ShouldExtractAllChunks()
    {
        // Arrange
        var text = @"# Main Title

## Subtitle

Here is a paragraph with some text.

```csharp
public class Test
{
    public void Method() { }
}
```

<table class=""custom-table"">
    <thead>
        <tr>
            <th>Header 1</th>
            <th>Header 2</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Data 1</td>
            <td>Data 2</td>
        </tr>
    </tbody>
</table>

![Image Alt](https://example.com/image.jpg)

## Another Subtitle

More text here.";

        var expectedHeaders = new[]
        {
            new ChunkModel
            {
                ChunkType = ChunkType.Topic,
                RelatedChunksIndexes = [],
                RawContent = @"# Main Title",
                Data = new Dictionary<string, object>()
                {
                    ["name"] = "Main Title",
                    ["level"] = 1,
                },
            },
            new ChunkModel
            {
                ChunkType = ChunkType.Topic,
                RelatedChunksIndexes = [],
                RawContent = @"## Subtitle",
                Data = new Dictionary<string, object>()
                {
                    ["name"] = "Subtitle",
                    ["level"] = 2,
                },
            },
            new ChunkModel
            {
                ChunkType = ChunkType.Topic,
                RelatedChunksIndexes = [],
                RawContent = @"## Another Subtitle",
                Data = new Dictionary<string, object>()
                {
                    ["name"] = "Another Subtitle",
                    ["level"] = 2,
                },
            },
        };
        var expectedCodeBlocks = new[]
        {
            new ChunkModel
            {
                ChunkType = ChunkType.CodeBlock,
                RelatedChunksIndexes = [],
                RawContent = @"```csharp
public class Test
{
    public void Method() { }
}
```",
                Data = new Dictionary<string, object>()
                {
                    ["language"] = "csharp",
                    ["content"] = @"```csharp
public class Test
{
    public void Method() { }
}
```",
                },
            },
        };
        var expectedTables = new[]
        {
            new ChunkModel
            {
                ChunkType = ChunkType.Table,
                RelatedChunksIndexes = [],
                Data = new Dictionary<string, object>()
                {
                    ["content"] = @"<table class=""custom-table"">
    <thead>
        <tr>
            <th>Header 1</th>
            <th>Header 2</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Data 1</td>
            <td>Data 2</td>
        </tr>
    </tbody>
</table>",
                },
                RawContent = @"<table class=""custom-table"">
    <thead>
        <tr>
            <th>Header 1</th>
            <th>Header 2</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Data 1</td>
            <td>Data 2</td>
        </tr>
    </tbody>
</table>",
            }
        };
        var expectedImages = new[]
        {
            new ChunkModel
            {
                ChunkType = ChunkType.ImageLink,
                RelatedChunksIndexes = [],
                RawContent = @"![Image Alt](https://example.com/image.jpg)",
                Data = new Dictionary<string, object>()
                {
                    ["url"] = "https://example.com/image.jpg",
                    ["alterText"] = "Image Alt",
                },
            }
        };
        
        // Act
        var chunks = text.RetrieveChunksFromText(withTables: true, withInfoBlocks: true, withCodeBlocks: true, withImages: true, withLinks: true);

        // Assert
        var chunksList = chunks.SelectMany(x => x.Value).ToArray();
        chunksList.Should().HaveCount(6); // 3 headers, 1 code block, 1 table, 1 image

        var headers = chunks[ChunkType.Topic];
        headers.Should().BeEquivalentTo(expectedHeaders, options => options
            .Excluding(x => x.Index));

        var codeBlocks = chunks[ChunkType.CodeBlock];
        codeBlocks.Should().BeEquivalentTo(expectedCodeBlocks, options => options
            .Excluding(x => x.Index));

        var tables = chunks[ChunkType.Table];
        tables.Should().BeEquivalentTo(expectedTables, options => options
            .Excluding(x => x.Index));

        var images = chunks[ChunkType.ImageLink];
        images.Should().BeEquivalentTo(expectedImages, options => options
            .Excluding(x => x.Index));
    }

    [Test]
    public void RetrieveChunksFromText_WithNestedContent_ShouldExtractCorrectly()
    {
        // Arrange
        var text = @"# Title with `inline code`

## Subtitle with [link](https://example.com)

```html
<table>
    <tr><td>Nested table</td></tr>
</table>
```

<table>
    <tr>
        <td>
            <h1>Nested header</h1>
            <img src=""nested.jpg"" alt=""Nested image"">
        </td>
    </tr>
</table>

```
[ WITH <common_table_expression> [,...n] ]
MERGE
    [ TOP ( expression ) [ PERCENT ] ]
    [ INTO ] <target_table> [ WITH ( <merge_hint> ) ] [ [ AS ] table_alias ]
    USING <table_source> [ [ AS ] table_alias ]
    ON <merge_search_condition>
    [ WHEN MATCHED [ AND <clause_search_condition> ]
        THEN <merge_matched> ] [ ...n ]
    [ WHEN NOT MATCHED [ BY TARGET ] [ AND <clause_search_condition> ]
        THEN <merge_not_matched> ]
    [ WHEN NOT MATCHED BY SOURCE [ AND <clause_search_condition> ]
        THEN <merge_matched> ] [ ...n ]
    [ <output_clause> ]
    [ OPTION ( <query_hint> [ ,...n ] ) ]
;

<target_table> ::=
{
    [ database_name . schema_name . | schema_name . ] [ [ AS ] target_table ]
    | @variable [ [ AS ] target_table ]
    | common_table_expression_name [ [ AS ] target_table ]
}

<merge_hint>::=
{
    { [ <table_hint_limited> [ ,...n ] ]
    [ [ , ] { INDEX ( index_val [ ,...n ] ) | INDEX = index_val }]
    }
}

<merge_search_condition> ::=
    <search_condition>

<merge_matched>::=
    { UPDATE SET <set_clause> | DELETE }

<merge_not_matched>::=
{
    INSERT [ ( column_list ) ]
        { VALUES ( values_list )
        | DEFAULT VALUES }
}

<clause_search_condition> ::=
    <search_condition>
```";

        var expectedCodeBlocks = new[]
        {
            new ChunkModel
            {
                Index = 1,
                ChunkType = ChunkType.CodeBlock,
                RelatedChunksIndexes = [],
                RawContent = @"```html
<table>
    <tr><td>Nested table</td></tr>
</table>
```",
                Data = new Dictionary<string, object>()
                {
                    ["content"] = @"```html
<table>
    <tr><td>Nested table</td></tr>
</table>
```",
                    ["language"] = "html",
                },
            },
            new ChunkModel
            {
                Index = 2,
                ChunkType = ChunkType.CodeBlock,
                RelatedChunksIndexes = [],
                RawContent = @"```
[ WITH <common_table_expression> [,...n] ]
MERGE
    [ TOP ( expression ) [ PERCENT ] ]
    [ INTO ] <target_table> [ WITH ( <merge_hint> ) ] [ [ AS ] table_alias ]
    USING <table_source> [ [ AS ] table_alias ]
    ON <merge_search_condition>
    [ WHEN MATCHED [ AND <clause_search_condition> ]
        THEN <merge_matched> ] [ ...n ]
    [ WHEN NOT MATCHED [ BY TARGET ] [ AND <clause_search_condition> ]
        THEN <merge_not_matched> ]
    [ WHEN NOT MATCHED BY SOURCE [ AND <clause_search_condition> ]
        THEN <merge_matched> ] [ ...n ]
    [ <output_clause> ]
    [ OPTION ( <query_hint> [ ,...n ] ) ]
;

<target_table> ::=
{
    [ database_name . schema_name . | schema_name . ] [ [ AS ] target_table ]
    | @variable [ [ AS ] target_table ]
    | common_table_expression_name [ [ AS ] target_table ]
}

<merge_hint>::=
{
    { [ <table_hint_limited> [ ,...n ] ]
    [ [ , ] { INDEX ( index_val [ ,...n ] ) | INDEX = index_val }]
    }
}

<merge_search_condition> ::=
    <search_condition>

<merge_matched>::=
    { UPDATE SET <set_clause> | DELETE }

<merge_not_matched>::=
{
    INSERT [ ( column_list ) ]
        { VALUES ( values_list )
        | DEFAULT VALUES }
}

<clause_search_condition> ::=
    <search_condition>
```",
                Data = new Dictionary<string, object>()
                {
                    ["content"] = @"```
[ WITH <common_table_expression> [,...n] ]
MERGE
    [ TOP ( expression ) [ PERCENT ] ]
    [ INTO ] <target_table> [ WITH ( <merge_hint> ) ] [ [ AS ] table_alias ]
    USING <table_source> [ [ AS ] table_alias ]
    ON <merge_search_condition>
    [ WHEN MATCHED [ AND <clause_search_condition> ]
        THEN <merge_matched> ] [ ...n ]
    [ WHEN NOT MATCHED [ BY TARGET ] [ AND <clause_search_condition> ]
        THEN <merge_not_matched> ]
    [ WHEN NOT MATCHED BY SOURCE [ AND <clause_search_condition> ]
        THEN <merge_matched> ] [ ...n ]
    [ <output_clause> ]
    [ OPTION ( <query_hint> [ ,...n ] ) ]
;

<target_table> ::=
{
    [ database_name . schema_name . | schema_name . ] [ [ AS ] target_table ]
    | @variable [ [ AS ] target_table ]
    | common_table_expression_name [ [ AS ] target_table ]
}

<merge_hint>::=
{
    { [ <table_hint_limited> [ ,...n ] ]
    [ [ , ] { INDEX ( index_val [ ,...n ] ) | INDEX = index_val }]
    }
}

<merge_search_condition> ::=
    <search_condition>

<merge_matched>::=
    { UPDATE SET <set_clause> | DELETE }

<merge_not_matched>::=
{
    INSERT [ ( column_list ) ]
        { VALUES ( values_list )
        | DEFAULT VALUES }
}

<clause_search_condition> ::=
    <search_condition>
```",
                    ["language"] = "unknown",
                },
            },
        };
        var expectedTables = new[]
        {
            new ChunkModel
            {
                Index = 3,
                ChunkType = ChunkType.Table,
                RelatedChunksIndexes = [],
                Data = new Dictionary<string, object>()
                {
                    ["content"] = @"<table>
    <tr>
        <td>
            <h1>Nested header</h1>
            <img src=""nested.jpg"" alt=""Nested image"">
        </td>
    </tr>
</table>",
                },
                RawContent = @"<table>
    <tr>
        <td>
            <h1>Nested header</h1>
            <img src=""nested.jpg"" alt=""Nested image"">
        </td>
    </tr>
</table>",
            }
        };
        var expectedLinks = new[]
        {
            new ChunkModel
            {
                Index = 4,
                ChunkType = ChunkType.AdditionalLink,
                RelatedChunksIndexes = [],
                RawContent = @"[link](https://example.com)",
                Data = new Dictionary<string, object>()
                {
                    ["url"] = "https://example.com",
                    ["alterText"] = "link",
                },
            }
        };
        var expectedHeaders = new[]
        {
            new ChunkModel
            {
                ChunkType = ChunkType.Topic,
                RelatedChunksIndexes = [],
                RawContent = @"# Title with `inline code`",
                Data = new Dictionary<string, object>()
                {
                    ["name"] = "Title with `inline code`",
                    ["level"] = 1,
                } 
            },
            new ChunkModel
            {
                ChunkType = ChunkType.Topic,
                RelatedChunksIndexes = new()
                {
                    [expectedLinks[0].ChunkType] = [expectedLinks[0].Index],
                },
                RawContent = @$"## Subtitle with link[RELATEDCHUNK]External-Link-{expectedLinks[0].Index}[/RELATEDCHUNK]",
                Data = new Dictionary<string, object>()
                {
                    ["name"] = "Subtitle with link",
                    ["level"] = 2,
                },
            },
        };


        // Act
        var chunks = text.RetrieveChunksFromText(withTables: true, withInfoBlocks: true, withCodeBlocks: true, withImages: true, withLinks: true);

        // Assert
        var chunksList = chunks.SelectMany(x => x.Value).ToArray();
        chunksList.Should().HaveCount(6); // 2 headers, 2 code block, 1 table, 1 link

        var headers = chunks[ChunkType.Topic];
        headers.Should().BeEquivalentTo(expectedHeaders, options => options
            .Excluding(x => x.Index));

        var codeBlocks = chunks[ChunkType.CodeBlock];
        codeBlocks.Should().BeEquivalentTo(expectedCodeBlocks, options => options
            .Excluding(x => x.Index));

        var tables = chunks[ChunkType.Table];
        tables.Should().BeEquivalentTo(expectedTables, options => options
            .Excluding(x => x.Index));

        var links = chunks[ChunkType.AdditionalLink];
        links.Should().BeEquivalentTo(expectedLinks);
    }

    [Test]
    public void ExtractSemanticChunksDeeply_WithRealWorldText_ShouldReturnCorrectChunks()
    {
        // Arrange
        var text = ArticlesTestData.DevToRealWorldArticleText;
        var expectedCodeBlocks = CodeBlocksTestData.DevToRealWorldArticleCodeBlocks;
        var expectedLinks = LinksTestData.DevToRealWorldArticleLinks;
        var expectedTexts = TextChunkTestData.DevToRealWorldArticleTextChunks;

        // Act
        var chunks = text.ExtractSemanticChunksDeeply(200, SemanticsType.Sentence, 0.5, withTables: true, withCodeBlocks: true, withImages: true, withLinks: true);

        // Assert
        var chunkList = chunks.SelectMany(x => x.Value).ToArray();
        chunkList.Should().NotBeEmpty();

        var codeBlocks = chunks[ChunkType.CodeBlock];
        codeBlocks.Should().BeEquivalentTo(expectedCodeBlocks);

        var textsChunks = chunks[ChunkType.TextChunk];
        textsChunks.Should().BeEquivalentTo(expectedTexts, options => options
            .Excluding(x => x.Index));

        var links = chunks[ChunkType.AdditionalLink];
        links.Should().BeEquivalentTo(expectedLinks);
    }

    [Test]
    public void ExtractSemanticChunksDeeply_WithRealWorldTextWithInfoBlocks_ShouldReturnCorrectChunks()
    {
        // Arrange
        var text = ArticlesTestData.ArticleWithMathInfoBlocks;
        var expectedInfoBlocks = InfoBlocksTestData.ArticleWithMathInfoBlocks;
        var expectedHeaders = HeadersTestData.ArticleWithMathInfoBlocksHeaders;

        // Act
        var chunks = text.ExtractSemanticChunksDeeply(200, SemanticsType.Sentence, 0.5, withTables: true, withCodeBlocks: true, withImages: true, withLinks: true);

        // Assert
        var chunkList = chunks.SelectMany(x => x.Value).ToArray();
        chunkList.Should().NotBeEmpty();

        var infoBlocks = chunks[ChunkType.InfoBlock];
        infoBlocks.Should().BeEquivalentTo(expectedInfoBlocks);

        var headers = chunks[ChunkType.Topic];
        headers.Should().BeEquivalentTo(expectedHeaders);
    }

    [Test]
    public void ExtractSemanticChunksDeeply_WithRealWorldTextWithUnusualCodeBlocks_ShouldReturnCorrectChunks()
    {
        // Arrange
        var text = ArticlesTestData.ArticleWithUnusualCodeBlocks;
        var expectedCodeBlocks = CodeBlocksTestData.ArticleWithUnusualCodeBlocks;

        // Act
        var chunks = text.ExtractSemanticChunksDeeply(200, SemanticsType.Sentence, 0.5, withTables: true, withCodeBlocks: true, withImages: true, withLinks: true);

        // Assert
        var chunkList = chunks.SelectMany(x => x.Value).ToArray();
        chunkList.Should().NotBeEmpty();

        var codeBlocks = chunks[ChunkType.CodeBlock];
        codeBlocks.Should().BeEquivalentTo(expectedCodeBlocks);
    }

    [Test]
    public void ExtractSemanticChunksDeeply_WithRealWorldTextWithComplexNestedTables_ShouldReturnCorrectChunks()
    {
        // Arrange
        var text = ArticlesTestData.WikipediaArticleWithComplexNestedTables;
        var expectedTables = TablesTestData.WikipediaArticleWithComplexNestedTables;

        // Act
        var chunks = text.ExtractSemanticChunksDeeply(200, SemanticsType.Sentence, 0.5, withTables: true, withCodeBlocks: true, withImages: true, withLinks: true);

        // Assert
        var chunkList = chunks.SelectMany(x => x.Value).ToArray();
        chunkList.Should().NotBeEmpty();

        var tables = chunks[ChunkType.Table];
        tables.Should().BeEquivalentTo(expectedTables);
    }

    [Test]
    public void ExtractSemanticChunksDeeply_WithRealWorldTextsCollection_ShouldReturnCorrectChunks()
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

        var expectedCodeBlocks = new Dictionary<int, ChunkModel[]>
        {
            [0] = CodeBlocksTestData.DevToRealWorldArticleCodeBlocks,
            [2] = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks,
        }.SelectMany(x => x.Value.Select(y => new ChunkModel
            {
                Index = y.Index + indexShiftValues[x.Key],
                ChunkType = y.ChunkType,
                RawContent = y.RawContent,
                RelatedChunksIndexes = y.RelatedChunksIndexes,
                Data = y.Data,
            })).ToArray();
        var expectedTables = new Dictionary<int, ChunkModel[]>
        {
            [2] = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables,
        }.SelectMany(x => x.Value.Select(y => new ChunkModel
            {
                Index = y.Index + indexShiftValues[x.Key],
                ChunkType = y.ChunkType,
                RawContent = y.RawContent,
                RelatedChunksIndexes = y.RelatedChunksIndexes,
                Data = y.Data,
            })).ToArray();
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
        var expectedHeaders = new Dictionary<int, ChunkModel[]>
        {
            [1] = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders,
            [2] = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders,
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
        var expectedTextsChunks = new Dictionary<int, ChunkModel[]>
        {
            [0] = TextChunkTestData.DevToRealWorldArticleTextChunks,
            [1] = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks,
            [2] = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks,
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
            }));

        // Act
        var chunks = texts.ExtractSemanticChunksDeeply(200, SemanticsType.Sentence, 0.5, withTables: true, withCodeBlocks: true, withImages: true, withLinks: true);

        // Assert
        var chunkList = chunks.SelectMany(x => x.Value).ToArray();
        chunkList.Should().NotBeEmpty();

        var codeBlocks = chunks.Values.SelectMany(x => x[ChunkType.CodeBlock])
                                      .ToArray();
        codeBlocks.Should().BeEquivalentTo(expectedCodeBlocks);

        var tables = chunks.Values.SelectMany(x => x[ChunkType.Table])
                                  .ToArray();
        tables.Should().BeEquivalentTo(expectedTables);

        var links = chunks.Values.SelectMany(x => x[ChunkType.AdditionalLink])
                                 .ToArray();
        links.Should().BeEquivalentTo(expectedLinks);

        var imageLinks = chunks.Values.SelectMany(x => x[ChunkType.ImageLink])
                                      .ToArray();
        imageLinks.Should().BeEquivalentTo(imageLinks);

        var headers = chunks.Values.SelectMany(x => x[ChunkType.Topic])
                                   .ToArray();
        headers.Should().BeEquivalentTo(expectedHeaders);

        var textsChunks = chunks.Values.SelectMany(x => x[ChunkType.TextChunk])
                                       .ToArray();
        textsChunks.Should().BeEquivalentTo(expectedTextsChunks);
    }
}
