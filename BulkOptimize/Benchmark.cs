using System.Diagnostics;
using System.Globalization;
using BulkOptimize.MemoryOptimize;
using BulkOptimize.SpeedOptimize;

namespace BulkOptimize;

static class Benchmark
{
    public static void Measure(string name, ITask task)
    {
        Console.WriteLine($"----- Benchmarking {name}...");

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        task.Run();
        stopwatch.Stop();

        Console.WriteLine("----- Elapsed time: {0}", stopwatch.ElapsedMilliseconds.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();
    }

    public static void Measure(string name, IAsyncTask task)
    {
        Console.WriteLine($"----- Benchmarking {name}...");

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        task.Run().Wait();
        stopwatch.Stop();

        Console.WriteLine("----- Elapsed time: {0}", stopwatch.ElapsedMilliseconds.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();
    }
}