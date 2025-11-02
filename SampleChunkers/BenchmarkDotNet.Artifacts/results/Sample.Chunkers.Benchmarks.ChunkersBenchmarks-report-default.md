
BenchmarkDotNet v0.13.12, Windows 11 (10.0.26200.7019)
AMD Ryzen 7 4800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]   : .NET 9.0.10 (9.0.1025.47515), X64 RyuJIT AVX2
  .NET 9.0 : .NET 9.0.10 (9.0.1025.47515), X64 RyuJIT AVX2

Job=.NET 9.0  Runtime=.NET 9.0  

 Method                                         | Mean            | Error           | StdDev          | Median          | Ratio    | RatioSD | Gen0      | Gen1      | Gen2     | Allocated  | Alloc Ratio |
----------------------------------------------- |----------------:|----------------:|----------------:|----------------:|---------:|--------:|----------:|----------:|---------:|-----------:|------------:|
 ExtractSemanticChunksFromText_Small            |     16,738.1 ns |       542.81 ns |     1,583.41 ns |     16,191.0 ns |     1.00 |    0.00 |    8.1177 |         - |        - |    17026 B |        1.00 |
 ExtractSemanticChunksFromText_Medium_Sentence  |    153,914.6 ns |     2,836.61 ns |     2,514.58 ns |    153,789.2 ns |     8.76 |    0.59 |   65.1855 |         - |        - |   136544 B |        8.02 |
 ExtractSemanticChunksFromText_Medium_Paragraph |              NA |              NA |              NA |              NA |        ? |       ? |        NA |        NA |       NA |         NA |           ? |
 ExtractSemanticChunksFromText_Large_Sentence   |  2,010,894.1 ns |    40,111.72 ns |   115,731.48 ns |  1,968,519.7 ns |   120.97 |   11.72 |  230.4688 |  195.3125 |        - |  1301853 B |       76.46 |
 ExtractSemanticChunksFromText_Large_Paragraph  |              NA |              NA |              NA |              NA |        ? |       ? |        NA |        NA |       NA |         NA |           ? |
 ExtractSemanticChunksFromText_VeryLarge        | 64,584,473.9 ns | 1,287,146.12 ns | 2,825,316.94 ns | 64,555,962.5 ns | 3,811.72 |  413.24 | 2500.0000 | 1125.0000 | 375.0000 | 14046859 B |      825.02 |
 PreprocessNaturalTextForChunking_Small         |        219.1 ns |         2.72 ns |         2.41 ns |        218.3 ns |     0.01 |    0.00 |         - |         - |        - |          - |        0.00 |
 PreprocessNaturalTextForChunking_Medium        |      1,301.0 ns |        19.66 ns |        21.03 ns |      1,302.5 ns |     0.07 |    0.01 |         - |         - |        - |          - |        0.00 |
 PreprocessNaturalTextForChunking_Large         |     14,565.3 ns |       289.41 ns |       529.20 ns |     14,488.7 ns |     0.85 |    0.08 |         - |         - |        - |          - |        0.00 |
 GetWords_Small                                 |      2,055.5 ns |        40.40 ns |        62.90 ns |      2,031.9 ns |     0.12 |    0.01 |    1.9798 |         - |        - |     4144 B |        0.24 |
 GetWords_Large                                 |    316,795.9 ns |     6,179.53 ns |     6,345.92 ns |    315,588.2 ns |    18.24 |    1.22 |   94.2383 |   42.4805 |        - |   405968 B |       23.84 |
 ExtractSentenceStartIndices                    |    132,826.9 ns |     2,598.35 ns |     2,888.06 ns |    131,451.0 ns |     7.55 |    0.61 |   29.2969 |         - |        - |    61480 B |        3.61 |
 ExtractParagraphStartIndexes                   |     24,375.4 ns |       474.33 ns |     1,041.16 ns |     24,262.6 ns |     1.44 |    0.15 |   19.4092 |         - |        - |    40608 B |        2.39 |
 ExtractSemanticChunksDeeply_PlainText          |    210,955.1 ns |     4,155.00 ns |     6,826.78 ns |    209,938.7 ns |    12.05 |    1.24 |  121.5820 |         - |        - |   259031 B |       15.21 |
 ExtractSemanticChunksDeeply_MarkdownSimple     |    265,567.8 ns |     5,123.80 ns |     6,840.13 ns |    263,199.6 ns |    14.66 |    1.32 |  173.8281 |   21.4844 |        - |   393692 B |       23.12 |
 ExtractSemanticChunksDeeply_MarkdownComplex    |  1,714,621.1 ns |    30,981.20 ns |    27,464.02 ns |  1,703,830.9 ns |    97.54 |    6.68 |  427.7344 |  236.3281 |   1.9531 |  1989717 B |      116.86 |
 RetrieveChunksFromText_SimpleMarkdown          |     19,954.4 ns |       396.35 ns |       628.65 ns |     19,844.7 ns |     1.13 |    0.11 |   47.0581 |         - |        - |    98544 B |        5.79 |
 RetrieveChunksFromText_ComplexMarkdown         |    181,386.3 ns |     3,534.78 ns |     3,471.62 ns |    180,673.6 ns |    10.40 |    0.72 |  133.5449 |   44.1895 |   0.2441 |   475968 B |       27.96 |
 BuildRelationsGraph_Medium                     |    218,149.9 ns |     4,189.51 ns |     6,397.82 ns |    216,293.2 ns |    12.30 |    1.14 |  155.0293 |         - |        - |   324711 B |       19.07 |
 BuildRelationsGraph_Complex                    |  1,754,827.8 ns |    32,759.47 ns |    29,040.42 ns |  1,755,364.6 ns |    99.84 |    6.97 |  435.5469 |  289.0625 |   1.9531 |  2011695 B |      118.15 |
 FindRepeatedChunksWithUrls                     |  2,060,841.2 ns |    40,645.66 ns |    46,807.60 ns |  2,039,222.5 ns |   116.32 |    9.54 |  550.7813 |  296.8750 |   3.9063 |  2386510 B |      140.17 |

Benchmarks with issues:
  ChunkersBenchmarks.ExtractSemanticChunksFromText_Medium_Paragraph: .NET 9.0(Runtime=.NET 9.0)
  ChunkersBenchmarks.ExtractSemanticChunksFromText_Large_Paragraph: .NET 9.0(Runtime=.NET 9.0)
