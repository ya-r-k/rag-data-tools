using BenchmarkDotNet.Running;

namespace Sample.Chunkers.Benchmarks;

/// <summary>
/// Точка входа для запуска бенчмарков.
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<ChunkersBenchmarks>();
    }
}

