using System;

public abstract class TrackableItem
{
    protected string _itemName;
    protected string _frequency;

    public TrackableItem(string itemName, string frequency)
    {
        _itemName = itemName;
        _frequency = frequency;        
    }

    public abstract void DisplayDashboardRow();

}