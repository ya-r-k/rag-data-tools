using BenchmarkDotNet.Running;
using RagDataTools.Benchmarks;

var summary = BenchmarkRunner.Run<ChunkersBenchmarks>();
