using FluentAssertions;
using RagDataTools.Chunkers.Extensions;
using RagDataTools.Chunkers.Infrastructure;

namespace RagDataTools.UnitTests.Chunkers.Extensions;

public class SimpleTextChunkerExtensionsTests
{
    [Test]
    public void ExtractSemanticChunksFromText_WhenSemanticTypeIsParagraphAndWithoutOverlap()
    {
        // Arrange
        var text = @"Now you know how Qdrant works. Getting started with Qdrant Cloud is just as easy. Create an account and use our SaaS completely free. We will take care of infrastructure maintenance and software updates.

                    To move onto some more complex examples of vector search, read our Tutorials and create your own app with the help of our Examples.

                    Note: There is another way of running Qdrant locally. If you are a Python developer, we recommend that you try Local Mode in Qdrant Client, as it only takes a few moments to get setup.";

        var chunkSize = 40;
        var type = PrimitivesExtractors.ParagraphsExtractor;

        var expectedChunks = new[]
        {
            "Now you know how Qdrant works. Getting started with Qdrant Cloud is just as easy. Create an account and use our SaaS completely free. We will take care of infrastructure maintenance and software updates.",
            "To move onto some more complex examples of vector search, read our Tutorials and create your own app with the help of our Examples.",
            "Note: There is another way of running Qdrant locally. If you are a Python developer, we recommend that you try Local Mode in Qdrant Client, as it only takes a few moments to get setup."
        };

        // Act
        var actualChunks = text.ExtractSemanticChunksFromText(chunkSize, type);

        // Assert
        actualChunks.Should().NotBeEmpty();
        actualChunks.Length.Should().BeGreaterThan(1);
    }

    [Test]
    public void ExtractSemanticChunksFromText_WhenSemanticTypeIsSentenceAndWithoutOverlap()
    {
        // Arrange
        var text = @"Now you know how Qdrant works. Getting started with Qdrant Cloud is just as easy. Create an account and use our SaaS completely free. We will take care of infrastructure maintenance and software updates.

                    To move onto some more complex examples of vector search, read our Tutorials and create your own app with the help of our Examples.

                    Note: There is another way of running Qdrant locally. If you are a Python developer, we recommend that you try Local Mode in Qdrant Client, as it only takes a few moments to get setup.";

        var chunkSize = 40;
        var type = PrimitivesExtractors.SentencesExtractor;

        var expectedChunks = new[]
        {
            "Now you know how Qdrant works. Getting started with Qdrant Cloud is just as easy. Create an account and use our SaaS completely free. We will take care of infrastructure maintenance and software updates.\n\n ",
            "To move onto some more complex examples of vector search, read our Tutorials and create your own app with the help of our Examples.\n\n Note: There is another way of running Qdrant locally. ",
            "If you are a Python developer, we recommend that you try Local Mode in Qdrant Client, as it only takes a few moments to get setup."
        };

        // Act
        var actualChunks = text.ExtractSemanticChunksFromText(chunkSize, type);

        // Assert
        actualChunks.Should().BeEquivalentTo(expectedChunks, options => options.WithStrictOrdering());
    }

    [Test]
    public void ExtractSemanticChunksFromText_WhenSemanticTypeIsSentenceAndWithOverlap()
    {
        // https://dev.to/snappy_tuts/programming-is-a-ritual-not-just-a-skill-4ga9

        // Arrange
        var text = @"
When you write code, you're not just typing logic.
You're creating rituals. Repeating patterns.
Modern-day incantations that manipulate machines.

And every master developer eventually learns:

Programming is about mindset, rituals, and transformation — not just knowledge.

In this article, you'll learn how to turn your programming into a craft, build mental rituals, and transform debugging, learning, and building into something far more powerful.

There are thousands of articles on:

- Best IDEs
- Fastest frameworks
- Which language to learn in 2025

This isn't that.

This is about what elite developers do mentally and emotionally — and how to install those behaviors into your workflow, no matter what tools you use.";

        var chunkSize = 40;
        var type = PrimitivesExtractors.SentencesExtractor;
        var overlap = 0.5;

        var expectedChunks = new[]
        {
            "When you write code, you're not just typing logic.\n You're creating rituals. Repeating patterns.\n Modern-day incantations that manipulate machines.\n\n And every master developer eventually learns:\n\n Programming is about mindset, rituals, and transformation - not just knowledge.\n\n ",
            "And every master developer eventually learns:\n\n Programming is about mindset, rituals, and transformation - not just knowledge.\n\n ",
            "In this article, you'll learn how to turn your programming into a craft, build mental rituals, and transform debugging, learning, and building into something far more powerful.\n\n There are thousands of articles on:\n\n ",
            "There are thousands of articles on:\n\n - Best IDEs\n - Fastest frameworks\n - Which language to learn in 2025\n\n This isn't that.\n\n ",
            "This is about what elite developers do mentally and emotionally - and how to install those behaviors into your workflow, no matter what tools you use.",
        };

        // Act
        var actualChunks = text.ExtractSemanticChunksFromText(chunkSize, type, overlap);

        // Assert
        actualChunks.Should().NotBeEmpty();
        actualChunks.Length.Should().BeGreaterThan(1);
        actualChunks.Should().BeEquivalentTo(expectedChunks, options => options.WithStrictOrdering());
    }

    [Test]
    public void ExtractSemanticChunksFromText_WhenSemanticTypeIsParagraphAndWithOverlap()
    {
        // https://dev.to/snappy_tuts/programming-is-a-ritual-not-just-a-skill-4ga9

        // Arrange
        var text = @"
When you write code, you're not just typing logic.
You're creating rituals. Repeating patterns.
Modern-day incantations that manipulate machines.

And every master developer eventually learns:

Programming is about mindset, rituals, and transformation — not just knowledge.

In this article, you'll learn how to turn your programming into a craft, build mental rituals, and transform debugging, learning, and building into something far more powerful.

There are thousands of articles on:

- Best IDEs
- Fastest frameworks
- Which language to learn in 2025

This isn't that.

This is about what elite developers do mentally and emotionally — and how to install those behaviors into your workflow, no matter what tools you use.";

        var chunkSize = 40;
        var type = PrimitivesExtractors.ParagraphsExtractor;
        var overlap = 0.5;

        var expectedChunks = new[]
        {
            "When you write code, you're not just typing logic.\n You're creating rituals. Repeating patterns.\n Modern-day incantations that manipulate machines.\n\n And every master developer eventually learns:\n\n Programming is about mindset, rituals, and transformation - not just knowledge.\n\n ",
            "And every master developer eventually learns:\n\n Programming is about mindset, rituals, and transformation - not just knowledge.\n\n ",
            "In this article, you'll learn how to turn your programming into a craft, build mental rituals, and transform debugging, learning, and building into something far more powerful.\n\n There are thousands of articles on:\n\n - Best IDEs\n - Fastest frameworks\n ",
            "There are thousands of articles on:\n\n - Best IDEs\n - Fastest frameworks\n - Which language to learn in 2025\n\n This isn't that.\n\n ",
            "This is about what elite developers do mentally and emotionally - and how to install those behaviors into your workflow, no matter what tools you use.",
        };

        // Act
        var actualChunks = text.ExtractSemanticChunksFromText(chunkSize, type, overlap);

        // Assert
        actualChunks.Should().NotBeEmpty();
        actualChunks.Length.Should().BeGreaterThan(1);
        actualChunks.Should().BeEquivalentTo(expectedChunks, options => options.WithStrictOrdering());
    }
}
