using Sample.Chunkers.Models;
using Sample.Chunkers.Models.Enums;

namespace Sample.Chunkers.UnitTests.TestData;

internal static class ImageLinksTestData
{
    // https://www.geeksforgeeks.org/data-modeling-a-comprehensive-guide-for-analysts/
    internal static readonly ChunkModel[] GeeksForGeeksAboutDataModelingImageLinks =
    [
        new ChunkModel
        {
            Index = 1,
            ChunkType = ChunkType.ImageLink,
            RelatedChunksIndexes = [],
            RawContent = "!\\[News\\](https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg",
                ["alterText"] = "News\\",
            },
        },
        new ChunkModel
        {
            Index = 2,
            ChunkType = ChunkType.ImageLink,
            RelatedChunksIndexes = [],
            RawContent = "![Data-Modeling-in-Analysis](https://media.geeksforgeeks.org/wp-content/uploads/20240215112547/Data-Modeling-in-Analysis.webp)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://media.geeksforgeeks.org/wp-content/uploads/20240215112547/Data-Modeling-in-Analysis.webp",
                ["alterText"] = "Data-Modeling-in-Analysis",
            },
        },
        new ChunkModel
        {
            Index = 3,
            ChunkType = ChunkType.ImageLink,
            RelatedChunksIndexes = [],
            RawContent = "![modeling](https://media.geeksforgeeks.org/wp-content/uploads/20240215113046/modeling.webp)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://media.geeksforgeeks.org/wp-content/uploads/20240215113046/modeling.webp",
                ["alterText"] = "modeling",
            },
        },
        new ChunkModel
        {
            Index = 4,
            ChunkType = ChunkType.ImageLink,
            RelatedChunksIndexes = [],
            RawContent = "![daat](https://media.geeksforgeeks.org/wp-content/uploads/20240215113207/daat.webp)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://media.geeksforgeeks.org/wp-content/uploads/20240215113207/daat.webp",
                ["alterText"] = "daat",
            },
        },
        new ChunkModel
        {
            Index = 5,
            ChunkType = ChunkType.ImageLink,
            RelatedChunksIndexes = [],
            RawContent = "!\\[News\\](https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg",
                ["alterText"] = "News\\",
            },
        },
    ];

    // https://www.geeksforgeeks.org/basic-operators-in-relational-algebra-2/
    internal static readonly ChunkModel[] GeeksForGeeksAboutRelationalAlgebraImageLinks =
    [
        new ChunkModel
        {
            Index = 22,
            ChunkType = ChunkType.ImageLink,
            RelatedChunksIndexes = [],
            RawContent = "!\\[News\\](https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg",
                ["alterText"] = "News\\",
            },
        },
        new ChunkModel
        {
            Index = 23,
            ChunkType = ChunkType.ImageLink,
            RelatedChunksIndexes = [],
            RawContent = "![https://media.geeksforgeeks.org/auth/avatar.png](https://media.geeksforgeeks.org/wp-content/uploads/20200717172614/authPreLogo.png)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://media.geeksforgeeks.org/wp-content/uploads/20200717172614/authPreLogo.png",
                ["alterText"] = "https://media.geeksforgeeks.org/auth/avatar.png",
            },
        },
        new ChunkModel
        {
            Index = 24,
            ChunkType = ChunkType.ImageLink,
            RelatedChunksIndexes = [],
            RawContent = "!\\[News\\](https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://media.geeksforgeeks.org/auth-dashboard-uploads/Google-news.svg",
                ["alterText"] = "News\\",
            },
        },
    ];
}
