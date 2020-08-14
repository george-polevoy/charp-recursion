using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace recursion.Bench
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31, launchCount: 1, warmupCount: 1, targetCount: 1)]
    [RPlotExporter]
    public class RecursiveBench
    {
        [Params(1, 4, 16, 32)]
        public int N;
        
        [Benchmark(Baseline = true)]
        public int Iterative() => Fibo.Iterative(N);

        [Benchmark]
        public int Recursive() => Fibo.Recursive(N);

        [Benchmark]
        public int TailRecursive() => Fibo.TailRecursive(N);
    }
}