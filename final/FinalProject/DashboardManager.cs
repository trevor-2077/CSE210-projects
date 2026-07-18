public class DashboardManager
{
    private List<TrackableItem> _dashboardItems;

    public DashboardManager()
    {
        _dashboardItems = new List<TrackableItem>();
    }

    public void AddItem(TrackableItem item)
    {
        _dashboardItems.Add(item);
    }

    public void ShowDashboard()
    {
    Console.WriteLine("\n======================= QUALITY V QUANTITY DASHBOARD =======================");
        if (_dashboardItems.Count == 0) Console.WriteLine("Dashboard empty.");
        
        foreach (TrackableItem item in _dashboardItems)
        {
            // Dynamic runtime polymorphism executes here smoothly
            item.DisplayDashboardRow();
        }
        Console.WriteLine("============================================================================");
    }
}
