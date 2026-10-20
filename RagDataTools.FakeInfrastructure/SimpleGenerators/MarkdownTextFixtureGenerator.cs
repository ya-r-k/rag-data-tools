using System.Text;

namespace RagDataTools.FakeInfrastructure.SimpleGenerators;

public class MarkdownTextFixtureGenerator(TextDataGenerator textDataGenerator)
{
    public string GeneratePlainText(int wordCount)
    {
        return textDataGenerator.GenerateText(wordCount, wordCount, false, 0.0);
    }

    public string GenerateBenchmarkMarkdownText(int wordCount)
    {
        return this.BuildSectionedMarkdown(
            "Main Title",
            ["Subtitle 1", "Subtitle 3", "Subtitle 5", "Subtitle 7", "Subtitle 9"],
            wordCount,
            includeComplexBlocks: false);
    }

    public string GenerateBenchmarkComplexMarkdownText(int wordCount)
    {
        return this.BuildSectionedMarkdown(
            "Main Title",
            ["First Section"],
            wordCount,
            includeComplexBlocks: true);
    }

    public string GenerateHeadersMarkdownFixture()
    {
        return """
        # Main Title

        ## First Section

        ### First Subsection

        ### Second Subsection

        ## Second Section

        ### Third Subsection
        """;
    }

    public string GenerateInfoBlocksMarkdownFixture()
    {
        return """
        # Functions in Discrete Mathematics

        > 
        > 
        > **f(a) = b  ↔︎  g(b) = a**

        ## Pre-Image and Image

        > 
        > 
        > **(gof)(x) = g(f(x)), for all x ∈ A**

        ### One-One and Onto

        > 
        > 
        > **For one-one:**
        > 
        > Let a, b ∈ R such that f(a) = f(b) then,
        > ⇒ a = b
        > 
        > **Therefore, f: R ⇢ R is one-one.**
        """;
    }

    public string GenerateLinksMarkdownFixture()
    {
        return """
        # Related Reading

        - [Alex.omegapy - Medium](https://medium.com/@alex.omegapy)
        - [Introduction to recursion](https://www.geeksforgeeks.org/introduction-to-recursion-2/)
        - [Data structures](https://www.geeksforgeeks.org/data-structures/)
        - [Database schema](https://www.geeksforgeeks.org/database-schemas/)
        """;
    }

    public string GenerateImageLinksMarkdownFixture()
    {
        return """
        # Data Modeling Visuals

        ![Data-Modeling-in-Analysis](https://media.geeksforgeeks.org/wp-content/uploads/20240215112547/Data-Modeling-in-Analysis.webp)
        ![modeling](https://media.geeksforgeeks.org/wp-content/uploads/20240215113046/modeling.webp)
        ![daat](https://media.geeksforgeeks.org/wp-content/uploads/20240215113207/daat.webp)
        """;
    }

    public string GenerateTablesMarkdownFixture()
    {
        return """
        # Negation

        <table class="infobox">
          <tr><th colspan="2">Negation</th></tr>
          <tr><td colspan="2">NOT</td></tr>
        </table>

        <table>
          <tr><th>ROLL_NO</th><th>NAME</th></tr>
          <tr><td>1</td><td>ALICE</td></tr>
          <tr><td>2</td><td>BOB</td></tr>
        </table>
        """;
    }

    public string GenerateCodeBlocksMarkdownFixture()
    {
        return """
        # If Statement in Programming

        ```
        x is positive
        ```

        ```csharp
        if (condition)
        {
            // Code to execute if condition is true
        }
        ```

        ```c
        #include <stdio.h>

        int main()
        {
            int x = 5;
            if (x > 0) {
                printf("x is positive\n");
            }

            return 0;
        }
        ```
        """;
    }

    public string GenerateMixedRelationsMarkdownFixture()
    {
        return """
        # Data Modeling: A Comprehensive Guide for Analysts

        ## What is Data Modeling?

        Last Updated : 16 Jul, 2024

        Data modelling is a fundamental component that facilitates the organisation, structuring, and interpretation of complicated datasets by analysts.

        ![Data-Modeling-in-Analysis](https://media.geeksforgeeks.org/wp-content/uploads/20240215112547/Data-Modeling-in-Analysis.webp)

        [data structure.](https://www.geeksforgeeks.org/data-structures/)
        [database schema.](https://www.geeksforgeeks.org/database-schemas/)

        ## Types of Data Models

        - **Conceptual Data Model**
        - **Logical Data Model**
        - **Physical Data Model**

        ## Benefits of Data Modeling

        ```text
        σ (Cond)(Relation Name)
        ```

        <table>
          <tr><th>ROLL_NO</th><th>NAME</th></tr>
          <tr><td>1</td><td>ALICE</td></tr>
          <tr><td>2</td><td>BOB</td></tr>
        </table>
        """;
    }

    public string GenerateDevToRealWorldArticle()
    {
        return """
        # Recursion in Programming: Techniques, Benefits, and Limitations

        This article explains recursion in programming, where a function calls itself to solve smaller instances of a problem.
        It covers applications in tree traversal, divide-and-conquer algorithms, and stack overflow risks.

        ## Base Cases and Recursive Cases

        A base case stops recursion. A recursive case keeps calling the function until that base case is reached.

        ```java
        public class Factorial {
            public static int factorial(int n) {
                if (n == 0) {
                    return 1;
                }

                return n * factorial(n - 1);
            }
        }
        ```

        ## Depth-First Search

        Recursive DFS is convenient, but an explicit stack avoids overflow on deep trees.

        ```java
        import java.util.ArrayDeque;
        import java.util.Deque;
        ```

        * * *

        **References:**

        - [Alex.omegapy - Medium](https://medium.com/@alex.omegapy)
        - [Introduction to recursion](https://www.geeksforgeeks.org/introduction-to-recursion-2/)
        """;
    }

    public string GenerateArticleWithMathInfoBlocks()
    {
        return this.GenerateInfoBlocksMarkdownFixture();
    }

    public string GenerateArticleWithUnusualCodeBlocks()
    {
        return this.GenerateCodeBlocksMarkdownFixture();
    }

    public string GenerateDataModelingArticle()
    {
        return this.GenerateImageLinksMarkdownFixture();
    }

    public string GenerateRelationalAlgebraArticle()
    {
        return this.GenerateTablesMarkdownFixture();
    }

    public string GenerateWikipediaNestedTablesArticle()
    {
        return """
        # Wikipedia Article With Nested Tables

        <table>
          <tr>
            <td>
              <table>
                <tr><td>Nested 1</td></tr>
              </table>
            </td>
            <td>
              <table>
                <tr><td>Nested 2</td></tr>
              </table>
            </td>
          </tr>
        </table>

        [Related article](https://example.com/related)
        """;
    }

    private string BuildSectionedMarkdown(
        string title,
        IReadOnlyList<string> subtitles,
        int wordCount,
        bool includeComplexBlocks)
    {
        var builder = new StringBuilder();
        builder.AppendLine($"# {title}");
        builder.AppendLine();

        var sections = Math.Max(1, subtitles.Count);
        var wordsPerSection = Math.Max(1, wordCount / sections);

        for (var i = 0; i < sections; i++)
        {
            if (i < subtitles.Count)
            {
                builder.AppendLine($"## {subtitles[i]}");
                builder.AppendLine();
            }

            if (includeComplexBlocks)
            {
                builder.AppendLine("```csharp");
                builder.AppendLine("var code = \"example\";");
                builder.AppendLine("Console.WriteLine(code);");
                builder.AppendLine("```");
                builder.AppendLine();

                builder.AppendLine("> This is an info block");
                builder.AppendLine("> with multiple lines");
                builder.AppendLine();

                builder.AppendLine("<table>");
                builder.AppendLine("  <tr><td>Cell 1</td><td>Cell 2</td></tr>");
                builder.AppendLine("</table>");
                builder.AppendLine();

                builder.AppendLine("![Image](https://example.com/image.jpg)");
                builder.AppendLine();

                builder.AppendLine("[Link](https://example.com)");
                builder.AppendLine();
            }

            builder.AppendLine(this.GeneratePlainText(wordsPerSection));
            builder.AppendLine();
        }

        return builder.ToString().Trim();
    }
}
