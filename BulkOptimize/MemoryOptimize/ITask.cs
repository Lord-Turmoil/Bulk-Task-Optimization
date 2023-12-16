namespace BulkOptimize.MemoryOptimize;

interface ITask
{
    const int DataSize = 20;
    const int DataProcessingTime = 50;
    const int DataSavingTime = 1000;

    void Run();
}