using BenchmarkDotNet.Running;
using Collections;

BenchmarkRunner.Run<Benchmarks>(); // .Net 9 uses the ReadOnlySpan,
                                   // so the LINQ is better there