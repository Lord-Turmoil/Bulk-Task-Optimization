namespace BulkOptimize.MemoryOptimize;

class LoadPartTask : ITask
{
    public void Run()
    {
        List<int> data = [];
        foreach (var item in AllData())
        {
            data.Add(ProcessData(item));
        }
        Console.WriteLine();
        SaveData(data);
    }

    private IEnumerable<int> AllData()
    {
        for (int i = 0; i < ITask.DataSize; i++)
        {
            yield return i;
        }
    }

    private int ProcessData(int item)
    {
        Console.Write(item);
        Console.Write(" ");
        Thread.Sleep(ITask.DataProcessingTime);
        return item;
    }

    private void SaveData(List<int> data)
    {
        Console.WriteLine("Saving data...");
        Thread.Sleep(ITask.DataSavingTime);
    }
}