using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace recursion.Bench
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [IterationTime(100)]
    [AsciiDocExporter]
    [CsvExporter]
    [CsvMeasurementsExporter]
    [HtmlExporter]
    [PlainExporter]
    public class RecursiveBench
    {
        [Params(1, 4, 16, 32)]
        public int N;

        [Benchmark]
        public int Iterative() => Fibo.Iterative(N);

        [Benchmark(Baseline = true)]
        public int Recursive() => Fibo.Recursive(N);

        [Benchmark]
        public int TailRecursive() => Fibo.TailRecursive(N);
    }
}