namespace BulkOptimize.SpeedOptimize;

interface IAsyncTask
{
    const int BulkCount = 20;
    const int BulkProcessingTime = 100;
    const int BulkSavingTime = 500;

    Task Run();
}