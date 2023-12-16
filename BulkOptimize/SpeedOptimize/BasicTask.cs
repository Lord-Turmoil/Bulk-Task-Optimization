namespace BulkOptimize.SpeedOptimize;

class BasicTask : IAsyncTask
{
    public async Task Run()
    {
        foreach (int item in AllBulk())
        {
            Console.Write($"{item} ");
            await SaveBulk(item);
        }
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