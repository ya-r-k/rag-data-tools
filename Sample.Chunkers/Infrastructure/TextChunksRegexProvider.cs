using Sample.Chunkers.Interfaces;
using System.Text.RegularExpressions;

namespace Sample.Chunkers.Infrastructure;

public partial class TextChunksRegexProvider : ITextChunksRegexProvider
{
    [GeneratedRegex(@"(?<=[:]\n|\.|!|\?)\s+", RegexOptions.Multiline)]
    public partial Regex GetForExtractingSentencesBeginning();

    [GeneratedRegex(@" {2,}")]
    public partial Regex GetMultipleSpacesRegex();
}
