namespace RagDataTools.Connectors.Interfaces;

public interface IChunksRelationshipsRepository<TData>
{
    Task AddRelationshipsAsync(string flag, params TData[] relationships);
}
