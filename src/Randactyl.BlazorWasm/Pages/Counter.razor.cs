namespace Randactyl.BlazorWasm.Pages;

public partial class Counter(ILogger<Counter> logger)
{
    private int currentCount = 0;

    private void IncrementCount()
    {
        logger.LogDebug("Counter was {CurrentCount}", currentCount);
        currentCount++;
        logger.LogDebug("Counter is now {CurrentCount}", currentCount);
    }
}
