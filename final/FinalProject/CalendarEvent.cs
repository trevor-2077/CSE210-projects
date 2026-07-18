public class CalendarEvent
{
    private string _activityName;
    private string _dayOfWeek;
    private string _timeSlot;

    public CalendarEvent(string activityName, string dayOfWeek, string timeSlot)
    {
        _activityName = activityName;
        _dayOfWeek = dayOfWeek;
        _timeSlot = timeSlot;
    }

    public string GetDay()
    {
        return _dayOfWeek;
    }

    public void DisplayEventDetails()
    {
        Console.WriteLine($" - [{_timeSlot}] {_activityName}");
    }
}