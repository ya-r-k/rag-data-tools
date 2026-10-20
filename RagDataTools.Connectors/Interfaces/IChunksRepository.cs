using RagDataTools.Chunkers.Models;

namespace RagDataTools.Connectors.Interfaces;

/// <summary>
/// Persists chunks under a caller-provided scope id.
/// </summary>
public interface IChunksRepository<TFlag, TId>
    where TFlag : notnull
    where TId : notnull
{
    /// <summary>
    /// Adds chunks using one or more scope flags.
    /// </summary>
    Task AddAsync(TFlag[] flags, params ChunkModel[] chunks);

    /// <summary>
    /// Adds chunks under a single scope id.
    /// </summary>
    Task AddAsync(string scopeId, params ChunkModel[] chunks);

    /// <summary>
    /// Gets chunk ids by flag.
    /// </summary>
    Task<IDictionary<int, TId>> GetIndexesIdsPairsByFlagAsync(TFlag flag);

    /// <summary>
    /// Gets chunk ids by scope id.
    /// </summary>
    Task<IDictionary<int, TId>> GetIndexesIdsPairsByScopeIdAsync(string scopeId);

    /// <summary>
    /// Removes all chunks for a flag.
    /// </summary>
    Task RemoveFlagFromAllDataAsync(TFlag flag);

    /// <summary>
    /// Removes all chunks for a scope id.
    /// </summary>
    Task RemoveScopeAsync(string scopeId);
}
