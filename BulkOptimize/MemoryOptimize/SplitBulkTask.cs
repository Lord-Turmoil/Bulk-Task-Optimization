namespace BulkOptimize.MemoryOptimize;

class SplitBulkTask : ITask
{
    public void Run()
    {
        List<int> data = [];
        int bulkSize = 5;
        int currentSize = 0;
        foreach (var item in AllData())
        {
            data.Add(ProcessData(item));
            currentSize++;
            if (currentSize == bulkSize)
            {
                Console.WriteLine();
                SaveData(data);
                data = [];
                currentSize = 0;
            }
        }
        if (currentSize > 0)
        {
            Console.WriteLine();
            SaveData(data);
        }
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