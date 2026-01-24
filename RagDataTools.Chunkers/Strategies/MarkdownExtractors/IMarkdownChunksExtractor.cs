using RagDataTools.Chunkers.Models;
using System.Text;

namespace RagDataTools.Chunkers.Strategies.MarkdownExtractors;

public interface IMarkdownChunksExtractor
{
    public List<ChunkModel> ExtractChunksFromText(StringBuilder builder, int lastUsedIndex = 0);

    IMarkdownChunksExtractor SetNext(IMarkdownChunksExtractor next);
}
