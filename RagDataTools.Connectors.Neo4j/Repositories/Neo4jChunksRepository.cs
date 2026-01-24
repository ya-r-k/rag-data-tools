using Neo4j.Driver;
using RagDataTools.Chunkers.Models;
using RagDataTools.Connectors.Interfaces;

namespace RagDataTools.Connectors.Neo4j.Repositories;

public class Neo4jChunksRepository(IDriver driver) : IChunksRepository<string, string>
{
    public async Task AddAsync(string[] flags, params ChunkModel[] chunks)
    {
        await using var session = driver.AsyncSession(o => o.WithDatabase("neo4j"));

        var nodesParams = chunks; // temporary

        await session.ExecuteWriteAsync(async tx =>
        {
            string query = $@"UNWIND $nodesParams AS item
                              CALL apoc.create.node(['{flags[0]}', '{flags[1]}', COALESCE(item.type, 'Unknown')], item.properties) 
                              YIELD node
                              RETURN node";
            await tx.RunAsync(query, new { nodesParams });
        });
    }

    public async Task<IDictionary<int, string>> GetIndexesIdsPairsByFlagAsync(string flag)
    {
        await using var session = driver.AsyncSession(o => o.WithDatabase("neo4j"));

        var query = $@"MATCH (n:{flag})
                       RETURN n.elementId, n.temporary_index";

        var result = await session.ExecuteReadAsync(async tx =>
        {
            var result = await tx.RunAsync(query);
            var records = await result.ToListAsync();

            return records.Select(x => x["n"].As<INode>()).ToArray();
        });

        return result.ToDictionary(x => x.Properties["temporary_index"].As<int>(), x => x.ElementId);
    }

    public async Task RemoveFlagFromAllDataAsync(string flag)
    {
        await using var session = driver.AsyncSession(o => o.WithDatabase("neo4j"));

        await session.ExecuteWriteAsync(async tx =>
        {
            string query = $@"MATCH (n:{flag})
                              REMOVE n:{flag}, n.temporary_index
                              RETURN count(n) AS modifiedCount";

            await tx.RunAsync(query);
        });
    }
}
