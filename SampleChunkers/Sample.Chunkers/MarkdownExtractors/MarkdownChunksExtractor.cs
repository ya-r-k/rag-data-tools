using Sample.Chunkers.Models;
using System.Text;

namespace Sample.Chunkers.MarkdownExtractors;

public abstract class MarkdownChunksExtractor : IMarkdownChunksExtractor
{
    protected IMarkdownChunksExtractor? next;

    public abstract List<ChunkModel> ExtractChunksFromText(StringBuilder builder, int lastUsedIndex = 0);

    public IMarkdownChunksExtractor SetNext(IMarkdownChunksExtractor next)
    {
        this.next = next;
        return next;
    }

    protected List<ChunkModel> ExecuteNextExtractor(StringBuilder builder, List<ChunkModel> extractedChunks, int lastUsedIndex)
    {
        if (next is not null)
        {
            extractedChunks.AddRange(next.ExtractChunksFromText(builder, lastUsedIndex));
        }

        return [.. extractedChunks];
    }
}
