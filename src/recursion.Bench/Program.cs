using BenchmarkDotNet.Running;

namespace recursion.Bench
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<RecursiveBench>();
        }
    }
}