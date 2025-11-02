using Sample.Chunkers.Enums;
using Sample.Chunkers.Models;

namespace Sample.Chunkers.UnitTests.TestData;

internal class LinksTestData
{
    // https://dev.to/alex_ricciardi/recursion-in-programming-techniques-benefits-and-limitations-java-3o4p
    internal static readonly ChunkModel[] DevToRealWorldArticleLinks =
    [
        new ChunkModel
        {
            Index = 5,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[Alex.omegapy - Medium](https://medium.com/@alex.omegapy)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://medium.com/@alex.omegapy",
                ["alterText"] = "Alex.omegapy - Medium",
            },
        },
    ];

    // https://www.geeksforgeeks.org/data-modeling-a-comprehensive-guide-for-analysts/
    internal static readonly ChunkModel[] GeeksForGeeksAboutDataModelingLinks =
    [
        new ChunkModel
        {
            Index = 6,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[[RELATEDCHUNK]Image-Link-14[/RELATEDCHUNK]\r\n                                                    Follow](https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen",
                ["alterText"] = "[RELATEDCHUNK]Image-Link-14[/RELATEDCHUNK]\r\n                                                    Follow",
            },
        },
        new ChunkModel
        {
            Index = 7,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[data structure.](https://www.geeksforgeeks.org/data-structures/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/data-structures/",
                ["alterText"] = "data structure.",
            },
        },
        new ChunkModel
        {
            Index = 8,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[development](https://www.geeksforgeeks.org/class-10-social-science-economics-chapter-1-development/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/class-10-social-science-economics-chapter-1-development/",
                ["alterText"] = "development",
            },
        },
        new ChunkModel
        {
            Index = 9,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[database schema.](https://www.geeksforgeeks.org/database-schemas/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/database-schemas/",
                ["alterText"] = "database schema.",
            },
        },
        new ChunkModel
        {
            Index = 10,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[tree.](https://www.geeksforgeeks.org/introduction-to-tree-data-structure-and-algorithm-tutorials/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/introduction-to-tree-data-structure-and-algorithm-tutorials/",
                ["alterText"] = "tree.",
            },
        },
        new ChunkModel
        {
            Index = 11,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[database design](https://www.geeksforgeeks.org/significance-of-database-design/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/significance-of-database-design/",
                ["alterText"] = "database design",
            },
        },
        new ChunkModel
        {
            Index = 12,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[relational model](https://www.geeksforgeeks.org/relational-model-in-dbms/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/relational-model-in-dbms/",
                ["alterText"] = "relational model",
            },
        },
        new ChunkModel
        {
            Index = 13,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[entity-relationship model (ER model)](https://www.geeksforgeeks.org/introduction-of-er-model/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/introduction-of-er-model/",
                ["alterText"] = "entity-relationship model (ER model)",
            },
        },
        new ChunkModel
        {
            Index = 14,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[integrity](https://www.geeksforgeeks.org/integrity-importance-and-challenges/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/integrity-importance-and-challenges/",
                ["alterText"] = "integrity",
            },
        },
        new ChunkModel
        {
            Index = 15,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[normalization.](https://www.geeksforgeeks.org/introduction-of-database-normalization/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/introduction-of-database-normalization/",
                ["alterText"] = "normalization.",
            },
        },
        new ChunkModel
        {
            Index = 16,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[data analysis](https://www.geeksforgeeks.org/data-analysis-tutorial/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/data-analysis-tutorial/",
                ["alterText"] = "data analysis",
            },
        },
        new ChunkModel
        {
            Index = 17,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[Advertise with us](https://www.geeksforgeeks.org/about/contact-us/?listicles)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/about/contact-us/?listicles",
                ["alterText"] = "Advertise with us",
            },
        },
        new ChunkModel
        {
            Index = 18,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[Next Article](https://www.geeksforgeeks.org/what-are-the-advantages-and-disadvantages-of-random-forest/?ref=next_article)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/what-are-the-advantages-and-disadvantages-of-random-forest/?ref=next_article",
                ["alterText"] = "Next Article",
            },
        },
        new ChunkModel
        {
            Index = 19,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[What are the Advantages and Disadvantages of Random Forest?](https://www.geeksforgeeks.org/what-are-the-advantages-and-disadvantages-of-random-forest/?ref=next_article)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/what-are-the-advantages-and-disadvantages-of-random-forest/?ref=next_article",
                ["alterText"] = "What are the Advantages and Disadvantages of Random Forest?",
            },
        },
        new ChunkModel
        {
            Index = 20,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[R](https://www.geeksforgeeks.org/user/rahulpawar_7/contributions/?itm_source=geeksforgeeks&amp;itm_medium=article_author&amp;itm_campaign=auth_user)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/user/rahulpawar_7/contributions/?itm_source=geeksforgeeks&amp;itm_medium=article_author&amp;itm_campaign=auth_user",
                ["alterText"] = "R",
            },
        },
        new ChunkModel
        {
            Index = 21,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[rahulpawar_7](https://www.geeksforgeeks.org/user/rahulpawar_7/contributions/?itm_source=geeksforgeeks&amp;itm_medium=article_author&amp;itm_campaign=auth_user)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/user/rahulpawar_7/contributions/?itm_source=geeksforgeeks&amp;itm_medium=article_author&amp;itm_campaign=auth_user",
                ["alterText"] = "rahulpawar_7",
            },
        },
        new ChunkModel
        {
            Index = 22,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[[RELATEDCHUNK]Image-Link-14[/RELATEDCHUNK]](https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen",
                ["alterText"] = "[RELATEDCHUNK]Image-Link-14[/RELATEDCHUNK]",
            },
        },
        new ChunkModel
        {
            Index = 23,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[Data Analysis](https://www.geeksforgeeks.org/category/ai-ml-ds/r-data-analysis/?ref=article_category)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/category/ai-ml-ds/r-data-analysis/?ref=article_category",
                ["alterText"] = "Data Analysis",
            },
        },
        new ChunkModel
        {
            Index = 24,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[AI-ML-DS](https://www.geeksforgeeks.org/category/ai-ml-ds/?ref=article_category)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/category/ai-ml-ds/?ref=article_category",
                ["alterText"] = "AI-ML-DS",
            },
        },
    ];

    // https://www.geeksforgeeks.org/basic-operators-in-relational-algebra-2/
    internal static readonly ChunkModel[] GeeksForGeeksAboutRelationalAlgebraLinks =
    [
        new ChunkModel
        {
            Index = 25,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[[RELATEDCHUNK]Image-Link-82[/RELATEDCHUNK]\r\n                                                    Follow](https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen",
                ["alterText"] = "[RELATEDCHUNK]Image-Link-82[/RELATEDCHUNK]\r\n                                                    Follow",
            },
        },
        new ChunkModel
        {
            Index = 26,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[Note:** [SELECT operation](https://www.geeksforgeeks.org/select-operation-in-relational-algebra/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/select-operation-in-relational-algebra/",
                ["alterText"] = "Note:** [SELECT operation",
            },
        },
        new ChunkModel
        {
            Index = 27,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[Rename operator](https://www.geeksforgeeks.org/rename-operation-in-relational-algebra/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/rename-operation-in-relational-algebra/",
                ["alterText"] = "Rename operator",
            },
        },
        new ChunkModel
        {
            Index = 28,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[Natural Join](https://www.geeksforgeeks.org/sql-natural-join/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/sql-natural-join/",
                ["alterText"] = "Natural Join",
            },
        },
        new ChunkModel
        {
            Index = 29,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[Relational Algebra](https://www.geeksforgeeks.org/introduction-of-relational-algebra-in-dbms/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/introduction-of-relational-algebra-in-dbms/",
                ["alterText"] = "Relational Algebra",
            },
        },
        new ChunkModel
        {
            Index = 30,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[database](https://www.geeksforgeeks.org/what-is-database/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/what-is-database/",
                ["alterText"] = "database",
            },
        },
        new ChunkModel
        {
            Index = 31,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[SQL](https://www.geeksforgeeks.org/what-is-sql/)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/what-is-sql/",
                ["alterText"] = "SQL",
            },
        },
        new ChunkModel
        {
            Index = 32,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[Advertise with us](https://www.geeksforgeeks.org/about/contact-us/?listicles)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/about/contact-us/?listicles",
                ["alterText"] = "Advertise with us",
            },
        },
        new ChunkModel
        {
            Index = 33,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[Next Article](https://www.geeksforgeeks.org/extended-operators-in-relational-algebra/?ref=next_article)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/extended-operators-in-relational-algebra/?ref=next_article",
                ["alterText"] = "Next Article",
            },
        },
        new ChunkModel
        {
            Index = 34,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[Extended Operators in Relational Algebra](https://www.geeksforgeeks.org/extended-operators-in-relational-algebra/?ref=next_article)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/extended-operators-in-relational-algebra/?ref=next_article",
                ["alterText"] = "Extended Operators in Relational Algebra",
            },
        },
        new ChunkModel
        {
            Index = 35,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[[RELATEDCHUNK]Image-Link-82[/RELATEDCHUNK]](https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://news.google.com/publications/CAAqBwgKMLTrzwsw44bnAw?hl=en-IN&amp;gl=IN&amp;ceid=IN%3Aen",
                ["alterText"] = "[RELATEDCHUNK]Image-Link-82[/RELATEDCHUNK]",
            },
        },
        new ChunkModel
        {
            Index = 36,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[DBMS](https://www.geeksforgeeks.org/category/computer-subject/dbms/?ref=article_category)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/category/computer-subject/dbms/?ref=article_category",
                ["alterText"] = "DBMS",
            },
        },
        new ChunkModel
        {
            Index = 37,
            ChunkType = ChunkType.AdditionalLink,
            RelatedChunksIndexes = [],
            RawContent = "[DBMS-Relational Algebra](https://www.geeksforgeeks.org/tag/dbms-relational-algebra/?ref=article_tag)",
            Data = new Dictionary<string, object>
            {
                ["url"] = "https://www.geeksforgeeks.org/tag/dbms-relational-algebra/?ref=article_tag",
                ["alterText"] = "DBMS-Relational Algebra",
            },
        },
    ];
}
