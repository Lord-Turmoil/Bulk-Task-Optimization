using BulkOptimize.MemoryOptimize;
using BulkOptimize.SpeedOptimize;

namespace BulkOptimize;

class Program
{
    private static void Main(string[] args)
    {
        // Benchmark.Measure("Original Task", new OriginalTask());
        // Benchmark.Measure("Load Part Task", new LoadPartTask());
        // Benchmark.Measure("Split Bulk Task", new SplitBulkTask());
        Benchmark.Measure("Basic Task", new BasicTask());
        Benchmark.Measure("Pipeline Task", new PipelineTask());
    }
}