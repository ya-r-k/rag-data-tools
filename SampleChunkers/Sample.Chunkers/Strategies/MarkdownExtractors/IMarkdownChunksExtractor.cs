using Sample.Chunkers.Models;
using System.Text;

namespace Sample.Chunkers.Strategies.MarkdownExtractors;

public interface IMarkdownChunksExtractor
{
    public List<ChunkModel> ExtractChunksFromText(StringBuilder builder, int lastUsedIndex = 0);

    IMarkdownChunksExtractor SetNext(IMarkdownChunksExtractor next);
}
