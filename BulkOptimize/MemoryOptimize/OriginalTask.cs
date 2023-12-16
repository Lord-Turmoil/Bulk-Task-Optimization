namespace BulkOptimize.MemoryOptimize;

class OriginalTask : ITask
{
    public void Run()
    {
        List<int> data = LoadData();
        ProcessData(data);
        SaveData(data);
    }

    private List<int> LoadData()
    {
        List<int> data = [];
        for (int i = 0; i < ITask.DataSize; i++)
        {
            data.Add(i);
        }
        return data;
    }

    private void ProcessData(List<int> data)
    {
        foreach (int item in data)
        {
            Console.Write(item);
            Console.Write(" ");
            Thread.Sleep(ITask.DataProcessingTime);
        }

        Console.WriteLine();
    }

    private void SaveData(List<int> data)
    {
        Console.WriteLine("Saving data...");
        Thread.Sleep(ITask.DataSavingTime);
    }
}