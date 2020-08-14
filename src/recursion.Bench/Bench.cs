using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace recursion.Bench
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [IterationTime(110)]
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
        public int Iterative() => Methods.Iterative(N);

        [Benchmark(Baseline = true)]
        public int Recursive() => Methods.Recursive(N);

        [Benchmark]
        public int TailRecursive() => Methods.TailRecursive(N);
    }
}