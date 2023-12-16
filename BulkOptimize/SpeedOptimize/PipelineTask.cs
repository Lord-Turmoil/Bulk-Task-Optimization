namespace BulkOptimize.SpeedOptimize;

class PipelineTask : IAsyncTask
{
    private const int MaxPipeline = 5;
    private readonly Task[] _tasks = new Task[MaxPipeline];

    public async Task Run()
    {
        for (int i = 0; i < MaxPipeline; i++)
        {
            _tasks[i] = Task.CompletedTask;
        }

        int currentTask = 0;
        foreach (int item in AllBulk())
        {
            Console.Write($"{item} ");
            await _tasks[currentTask];
            _tasks[currentTask] = SaveBulk(item);
            currentTask = (currentTask + 1) % MaxPipeline;
        }

        Task.WaitAll(_tasks);
        Console.WriteLine();
    }

    private IEnumerable<int> AllBulk()
    {
        for (int i = 0; i < IAsyncTask.BulkCount; i++)
        {
            Thread.Sleep(IAsyncTask.BulkProcessingTime);
            yield return i;
        }
    }

    private async Task SaveBulk(int bulk)
    {
        await Task.Delay(IAsyncTask.BulkSavingTime);
        Console.Write($"{bulk} ");
    }
}