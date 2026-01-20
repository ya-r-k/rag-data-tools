using Sample.Chunkers.Models;
using Sample.Chunkers.Models.Enums;

namespace Sample.Chunkers.UnitTests.TestData;

internal class InfoBlocksTestData
{
    // https://www.geeksforgeeks.org/functions-in-discrete-mathematics/
    internal static readonly ChunkModel[] ArticleWithMathInfoBlocks =
    [
        new ChunkModel
        {
            Index = 1,
            ChunkType = ChunkType.InfoBlock,
            RelatedChunksIndexes = [],
            RawContent = @"> 
> 
> **f(a) = b  ↔︎  g(b) = a**
>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"> 
> 
> **f(a) = b  ↔︎  g(b) = a**
>",
            },
        },
        new ChunkModel
        {
            Index = 2,
            ChunkType = ChunkType.InfoBlock,
            RelatedChunksIndexes = [],
            RawContent = @"> 
> 
> **(gof)(x) = g(f(x)), for all x ∈ A**
>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"> 
> 
> **(gof)(x) = g(f(x)), for all x ∈ A**
>",
            },
        },
        new ChunkModel
        {
            Index = 3,
            ChunkType = ChunkType.InfoBlock,
            RelatedChunksIndexes = [],
            RawContent = @"> 
> 
> **For one-one:**
> 
> 
> Let a, b ∈ R such that f(a) = f(b) then,
> 
> 
> f(a) = f(b) 
> 
> 
> ⇒ 2a = 2b 
> 
> 
> ⇒ a = b
> 
> 
> **Therefore, f: R ⇢ R is one-one.**
> 
> 
> **For onto:**
> 
> 
> Let p be any real number in R (co-domain). f(x) = p
> 
> 
> ⇒ 2x = p 
> 
> 
> ⇒ x = p/2
> 
> 
> p/2 ∈ R for p ∈ R such that f(p/2) = 2(p/2) = p 
> 
> 
> For each p∈ R (codomain) there exists x = p/2 ∈ R (domain) such that f(x) = y
> 
> 
> For each element in codomain has its pre-image in domain.
> 
> 
> So, f: R ⇢ R is onto.
> 
> 
> Since f: R ⇢ R is both one-one and onto.
> 
> 
> f : R ⇢ R is one-one correspondent (bijective function).
>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"> 
> 
> **For one-one:**
> 
> 
> Let a, b ∈ R such that f(a) = f(b) then,
> 
> 
> f(a) = f(b) 
> 
> 
> ⇒ 2a = 2b 
> 
> 
> ⇒ a = b
> 
> 
> **Therefore, f: R ⇢ R is one-one.**
> 
> 
> **For onto:**
> 
> 
> Let p be any real number in R (co-domain). f(x) = p
> 
> 
> ⇒ 2x = p 
> 
> 
> ⇒ x = p/2
> 
> 
> p/2 ∈ R for p ∈ R such that f(p/2) = 2(p/2) = p 
> 
> 
> For each p∈ R (codomain) there exists x = p/2 ∈ R (domain) such that f(x) = y
> 
> 
> For each element in codomain has its pre-image in domain.
> 
> 
> So, f: R ⇢ R is onto.
> 
> 
> Since f: R ⇢ R is both one-one and onto.
> 
> 
> f : R ⇢ R is one-one correspondent (bijective function).
>",
            },
        },
        new ChunkModel
        {
            Index = 4,
            ChunkType = ChunkType.InfoBlock,
            RelatedChunksIndexes = [],
            RawContent = @"> 
> 
> Since the range of f is a subset of the domain of g and the range of g is a subset of the domain of f. So, fog and gof both exist. 
> 
> 
> **gof (x)** = g(f(x)) = g(cos x) = (cos x)^3^ = cos^3^x
> 
> 
> **fog (x)** = f(g(x)) = f(x^3^) = cos x^3^
>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"> 
> 
> Since the range of f is a subset of the domain of g and the range of g is a subset of the domain of f. So, fog and gof both exist. 
> 
> 
> **gof (x)** = g(f(x)) = g(cos x) = (cos x)^3^ = cos^3^x
> 
> 
> **fog (x)** = f(g(x)) = f(x^3^) = cos x^3^
>",
            },
        },
        new ChunkModel
        {
            Index = 5,
            ChunkType = ChunkType.InfoBlock,
            RelatedChunksIndexes = [],
            RawContent = @"> 
> 
> Let f^-1^(16) = x
> 
> 
> f(x) = 16
> 
> 
> ⇒ x^2^ = 16
> 
> 
> ⇒ x = ± 4
> 
> 
> Thus, f^-1^(16) = {-4, 4}
>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"> 
> 
> Let f^-1^(16) = x
> 
> 
> f(x) = 16
> 
> 
> ⇒ x^2^ = 16
> 
> 
> ⇒ x = ± 4
> 
> 
> Thus, f^-1^(16) = {-4, 4}
>",
            },
        },
        new ChunkModel
        {
            Index = 6,
            ChunkType = ChunkType.InfoBlock,
            RelatedChunksIndexes = [],
            RawContent = @"> 
> 
> Let x ∈ R (domain), y ∈ R (codomain) such that f(a) = b
> 
> 
> f(x) = y
> 
> 
> ⇒ 2x + 7 = y
> 
> 
> ⇒ x = (y -7)/2
> 
> 
> ⇒ f^-1^(y) = (y -7)/2 
> 
> 
> Thus,  f^-1 : R^⇢ R is defined as f^-1(x) = (x -7)/2  for all x∈ R.^
>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"> 
> 
> Let x ∈ R (domain), y ∈ R (codomain) such that f(a) = b
> 
> 
> f(x) = y
> 
> 
> ⇒ 2x + 7 = y
> 
> 
> ⇒ x = (y -7)/2
> 
> 
> ⇒ f^-1^(y) = (y -7)/2 
> 
> 
> Thus,  f^-1 : R^⇢ R is defined as f^-1(x) = (x -7)/2  for all x∈ R.^
>",
            },
        },
        new ChunkModel
        {
            Index = 7,
            ChunkType = ChunkType.InfoBlock,
            RelatedChunksIndexes = [],
            RawContent = @"> 
> 
> Total number of functions = 3^5^ **** = 243
>",
            Data = new Dictionary<string, object>
            {
                ["content"] = @"> 
> 
> Total number of functions = 3^5^ **** = 243
>",
            },
        },
    ];
}
