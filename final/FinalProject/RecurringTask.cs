
public class RecurringTask : TrackableItem
{
    private int _targetCount;
    private int _currentCount;

    public RecurringTask(string itemName, string frequency, int targetCount)
        : base(itemName, frequency)
    {
        _targetCount = targetCount;
        _currentCount = 0;
    }

    public void LogProgress(int amount)
    {
        _currentCount += amount;
    }

    public override void DisplayDashboardRow()
    {
        Console.WriteLine($"[TASK]  {_itemName} ({_frequency}) -> Progress: {_currentCount}/{_targetCount} accomplished.");
    }
}
