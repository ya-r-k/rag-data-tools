using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using RagDataTools.Benchmarks;

var summary = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly)
    .Run(args, new DebugInProcessConfig());

//BenchmarkRunner.Run<ChunkersBenchmarks>();
