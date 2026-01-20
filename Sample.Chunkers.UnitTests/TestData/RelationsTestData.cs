using Sample.Chunkers.Models;
using Sample.Chunkers.Models.Enums;

namespace Sample.Chunkers.UnitTests.TestData;

internal static class RelationsTestData
{
    // https://www.geeksforgeeks.org/functions-in-discrete-mathematics/
    internal static readonly List<RelationshipModel> ArticleWithMathInfoBlocks =
    [
        // topics graph relations
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[0].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[1].Index,
            RelationshipType = RelationshipType.HasFirstSubtopic,
        }, // 34 - 35
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[1].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[2].Index,
            RelationshipType = RelationshipType.HasFirstSubtopic,
        }, // 35 - 36
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[2].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[3].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 36 - 37
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[3].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[4].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 37 - 38
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[1].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[5].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 35 - 39
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[5].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[6].Index,
            RelationshipType = RelationshipType.HasFirstSubtopic,
        }, // 39 - 40
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[6].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[7].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 40 - 41
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[7].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[8].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 41 - 42
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[8].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[9].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 42 - 43
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[9].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[10].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 43 - 44
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[10].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[11].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 44 - 45
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[11].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[12].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 45 - 46
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[12].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[13].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 46 - 47
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[5].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[14].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 39 - 48
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[14].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[15].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 48 - 49
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[15].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[16].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 49 - 50
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[16].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[17].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 50 - 51
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[17].Index,
            SecondChunkIndex = HeadersTestData.ArticleWithMathInfoBlocksHeaders[18].Index,
            RelationshipType = RelationshipType.HasFirstSubtopic,
        }, // 51 - 52
        // text chunk with index = 53 (1-th)
        // text chunk with index = 54 (2-th)
        // text chunk with index = 55 (3-th)
        // text chunk with index = 56 (4-th)
        // text chunk with index = 57 (5-th)
        // text chunk with index = 58 (6-th)
        // text chunk with index = 59 (7-th)
        // text chunk with index = 60 (8-th)
        // text chunk with index = 61 (9-th)
        new RelationshipModel
        {
            FirstChunkIndex = 61,
            SecondChunkIndex = InfoBlocksTestData.ArticleWithMathInfoBlocks[0].Index,
            RelationshipType = RelationshipType.RelatedInfoBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = 61,
            SecondChunkIndex = InfoBlocksTestData.ArticleWithMathInfoBlocks[1].Index,
            RelationshipType = RelationshipType.RelatedInfoBlock,
        },
        // text chunk with index = 62 (10-th)
        // text chunk with index = 63 (11-th)
        new RelationshipModel
        {
            FirstChunkIndex = 63,
            SecondChunkIndex = InfoBlocksTestData.ArticleWithMathInfoBlocks[2].Index,
            RelationshipType = RelationshipType.RelatedInfoBlock,
        },
        // text chunk with index = 64 (12-th)
        new RelationshipModel
        {
            FirstChunkIndex = 64,
            SecondChunkIndex = InfoBlocksTestData.ArticleWithMathInfoBlocks[3].Index,
            RelationshipType = RelationshipType.RelatedInfoBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = 64,
            SecondChunkIndex = InfoBlocksTestData.ArticleWithMathInfoBlocks[4].Index,
            RelationshipType = RelationshipType.RelatedInfoBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = 64,
            SecondChunkIndex = InfoBlocksTestData.ArticleWithMathInfoBlocks[5].Index,
            RelationshipType = RelationshipType.RelatedInfoBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = 64,
            SecondChunkIndex = InfoBlocksTestData.ArticleWithMathInfoBlocks[6].Index,
            RelationshipType = RelationshipType.RelatedInfoBlock,
        },
    ];

    internal static readonly List<RelationshipModel> DevToRealWorldArticleChunksRelations =
    [
        // text chunks sequence
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[0].Index,
            SecondChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[1].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 6 - 7
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[1].Index,
            SecondChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[2].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 7 - 8
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[2].Index,
            SecondChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[3].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 8 - 9
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[3].Index,
            SecondChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[4].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 9 - 10
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[4].Index,
            SecondChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[5].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 10 - 11
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[5].Index,
            SecondChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[6].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 11 - 12
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[6].Index,
            SecondChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[7].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 12 - 13
        // text chunk with index = 6 (1-th)
        // text chunk with index = 7 (2-th)
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[1].Index,
            SecondChunkIndex = CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[0].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        // text chunk with index = 8 (3-th)
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[2].Index,
            SecondChunkIndex = CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[0].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        // text chunk with index = 9 (4-th)
        // text chunk with index = 10 (5-th)
        // text chunk with index = 11 (6-th)
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[5].Index,
            SecondChunkIndex = CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[1].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[5].Index,
            SecondChunkIndex = CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[2].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        // text chunk with index = 12 (7-th)
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[6].Index,
            SecondChunkIndex = CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[1].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[6].Index,
            SecondChunkIndex = CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[2].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[6].Index,
            SecondChunkIndex = CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[3].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        // text chunk with index = 13 (8-th)
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[7].Index,
            SecondChunkIndex = CodeBlocksTestData.DevToRealWorldArticleCodeBlocks[3].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.DevToRealWorldArticleTextChunks[7].Index,
            SecondChunkIndex = LinksTestData.DevToRealWorldArticleLinks[0].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
    ];

    internal static readonly List<RelationshipModel> GeeksForGeeksAboutDataModelingChunksRelations =
    [
        // text chunks sequence
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[0].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[1].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 33 - 34
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[1].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[2].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 34 - 35
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[2].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[3].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 35 - 36
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[3].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[4].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 36 - 37
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[4].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[5].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 37 - 38
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[5].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[6].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 38 - 39
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[6].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[7].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 39 - 40
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[7].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[8].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 40 - 41
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[8].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[9].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 41 - 42
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[9].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[10].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 42 - 43
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[10].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[11].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 43 - 44
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[11].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[12].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 44 - 45
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[12].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[13].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 45 - 46
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[13].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[14].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 46 - 47
        // topics graph relations
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[0].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[1].Index,
            RelationshipType = RelationshipType.HasFirstSubtopic,
        }, // 25 - 26
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[1].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[2].Index,
            RelationshipType = RelationshipType.HasFirstSubtopic,
        }, // 26 - 27
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[1].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[3].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 26 - 28
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[3].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[4].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 28 - 29
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[4].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[5].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 29 - 30
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[5].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[6].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 30 - 31
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[6].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[7].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 31 - 32
        // text chunk with index = 33 (1-th)
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[0].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[0].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[1].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[0].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[0].Index,
            SecondChunkIndex = ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks[0].Index,
            RelationshipType = RelationshipType.RelatedImage,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[0].Index,
            SecondChunkIndex = ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks[1].Index,
            RelationshipType = RelationshipType.RelatedImage,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[0].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[0].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        // text chunk with index = 34 (2-th)
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[2].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[1].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[3].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[1].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[1].Index,
            SecondChunkIndex = ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks[2].Index,
            RelationshipType = RelationshipType.RelatedImage,
        },
        // text chunk with index = 35 (3-th)
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[3].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[2].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[2].Index,
            SecondChunkIndex = ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks[2].Index,
            RelationshipType = RelationshipType.RelatedImage,
        },
        // text chunk with index = 36 (4-th)
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[3].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[1].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        // text chunk with index = 37 (5-th)
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[4].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[4].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[4].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[5].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[4].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[1].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        // text chunk with index = 38 (6-th)
        // text chunk with index = 39 (7-th)
        // text chunk with index = 40 (8-th)
        // text chunk with index = 41 (9-th)
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[8].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[2].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[8].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[3].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        // text chunk with index = 42 (10-th)
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[5].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[9].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[9].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[2].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[9].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[3].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[9].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[4].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        // text chunk with index = 43 (11-th)
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[5].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[10].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[10].Index,
            SecondChunkIndex = ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks[3].Index,
            RelationshipType = RelationshipType.RelatedImage,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[10].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[4].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[10].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[5].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        // text chunk with index = 44 (12-th)
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[11].Index,
            SecondChunkIndex = ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks[3].Index,
            RelationshipType = RelationshipType.RelatedImage,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[11].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[5].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[11].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[6].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[11].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[7].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        // text chunk with index = 45 (13-th)
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[6].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[12].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[12].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[6].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[12].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[7].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        // text chunk with index = 46 (14-th)
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[6].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[13].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[7].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[13].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[13].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[8].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[13].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[9].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[13].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[10].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        // text chunk with index = 47 (15-th)
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutDataModelingHeaders[7].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[14].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[14].Index,
            SecondChunkIndex = ImageLinksTestData.GeeksForGeeksAboutDataModelingImageLinks[0].Index,
            RelationshipType = RelationshipType.RelatedImage,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[14].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[8].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[14].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[9].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[14].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[10].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[14].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[11].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[14].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[12].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[14].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[13].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[14].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[14].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[14].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[15].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[14].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[16].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[14].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[17].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutDataModelingTextChunks[14].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutDataModelingLinks[18].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
    ];

    internal static readonly List<RelationshipModel> GeeksForGeeksAboutRelationalAlgebraChunksRelations =
    [
        // text chunks sequence
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[0].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 47 - 48
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[2].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 48 - 49
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[2].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 49 - 50
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            RelationshipType = RelationshipType.HasNextChunk,
        }, // 50 - 51
        // topics graph relations
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[0].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[1].Index,
            RelationshipType = RelationshipType.HasFirstSubtopic,
        }, // 38 - 39
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[1].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[2].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 39 - 40
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[2].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[3].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 40 - 41
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[3].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[4].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 41 - 42
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[4].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[5].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 42 - 43
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[5].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[6].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 43 - 44
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[6].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[7].Index,
            RelationshipType = RelationshipType.HasFirstSubtopic,
        }, // 44 - 45
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[6].Index,
            SecondChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[8].Index,
            RelationshipType = RelationshipType.HasNextTopic,
        }, // 44 - 46
        // text chunk with index = 47 (1-th)
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[0].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[0].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[1].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[0].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[2].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[0].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[0].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[0].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[0].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[1].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[0].Index,
            SecondChunkIndex = ImageLinksTestData.GeeksForGeeksAboutRelationalAlgebraImageLinks[0].Index,
            RelationshipType = RelationshipType.RelatedImage,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[0].Index,
            SecondChunkIndex = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[0].Index,
            RelationshipType = RelationshipType.RelatedTable,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[0].Index,
            SecondChunkIndex = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[1].Index,
            RelationshipType = RelationshipType.RelatedTable,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[0].Index,
            SecondChunkIndex = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[2].Index,
            RelationshipType = RelationshipType.RelatedTable,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[0].Index,
            SecondChunkIndex = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[3].Index,
            RelationshipType = RelationshipType.RelatedTable,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[0].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[0].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[0].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[1].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        // text chunk with index = 48 (2-th)
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[1].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[2].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[3].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[0].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[1].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[2].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[3].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            SecondChunkIndex = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[0].Index,
            RelationshipType = RelationshipType.RelatedTable,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            SecondChunkIndex = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[1].Index,
            RelationshipType = RelationshipType.RelatedTable,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            SecondChunkIndex = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[2].Index,
            RelationshipType = RelationshipType.RelatedTable,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            SecondChunkIndex = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[3].Index,
            RelationshipType = RelationshipType.RelatedTable,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            SecondChunkIndex = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[4].Index,
            RelationshipType = RelationshipType.RelatedTable,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[1].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[1].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },                    
        // text chunk with index = 49 (3-th)
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[3].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[2].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[4].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[2].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[5].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[2].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[2].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[4].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[2].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[5].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[2].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[6].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[2].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[7].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[2].Index,
            SecondChunkIndex = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[5].Index,
            RelationshipType = RelationshipType.RelatedTable,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[2].Index,
            SecondChunkIndex = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[6].Index,
            RelationshipType = RelationshipType.RelatedTable,
        },
        // text chunk with index = 50 (4-th)
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[5].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[6].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[7].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[6].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[7].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[8].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[9].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[10].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[11].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[12].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            SecondChunkIndex = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[6].Index,
            RelationshipType = RelationshipType.RelatedTable,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            SecondChunkIndex = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[7].Index,
            RelationshipType = RelationshipType.RelatedTable,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[2].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[3].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[3].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        // text chunk with index = 51 (5-th)
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[6].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[7].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = HeadersTestData.GeeksForGeeksAboutRelationalAlgebraHeaders[8].Index,
            SecondChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            RelationshipType = RelationshipType.StartsWith,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[8].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[9].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[10].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[11].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = CodeBlocksTestData.GeeksForGeeksAboutRelationalAlgebraCodeBlocks[12].Index,
            RelationshipType = RelationshipType.RelatedCodeBlock,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = ImageLinksTestData.GeeksForGeeksAboutRelationalAlgebraImageLinks[0].Index,
            RelationshipType = RelationshipType.RelatedImage,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = ImageLinksTestData.GeeksForGeeksAboutRelationalAlgebraImageLinks[1].Index,
            RelationshipType = RelationshipType.RelatedImage,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = TablesTestData.GeeksForGeeksAboutRelationalAlgebraTables[7].Index,
            RelationshipType = RelationshipType.RelatedTable,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[2].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[3].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[4].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[5].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[6].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[7].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[8].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[9].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[10].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[11].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
        new RelationshipModel
        {
            FirstChunkIndex = TextChunkTestData.GeeksForGeeksAboutRelationalAlgebraTextChunks[4].Index,
            SecondChunkIndex = LinksTestData.GeeksForGeeksAboutRelationalAlgebraLinks[12].Index,
            RelationshipType = RelationshipType.AdditionalLink,
        },
    ];
}
