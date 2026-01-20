using Sample.Chunkers.Models;
using System.Text;

namespace Sample.Chunkers.MarkdownExtractors;

public interface IMarkdownChunksExtractor
{
    public List<ChunkModel> ExtractSematicChunksFromText(StringBuilder builder, int lastUsedIndex = 0);
}
