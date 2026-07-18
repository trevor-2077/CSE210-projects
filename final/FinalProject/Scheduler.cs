using System;

public class Scheduler
{
    private List<CalendarEvent> _events;

    public Scheduler()
    {
        _events = new List<CalendarEvent>();
    }

    public void AddEvent(string name, string day, string time)
    {
        _events.Add(new CalendarEvent(name, day, time));
    }

    public void ViewScheduleForDay(string day)
    {
        Console.WriteLine($"\n-- Schedule for {day} ---");
        bool found = false;
        foreach (CalendarEvent ev in _events)
        {
            if (ev.GetDay().Equals(day, StringComparison.OrdinalIgnoreCase))
            {
                ev.DisplayEventDetails();
                found = true;
            }
        }
        if (!found) Console.WriteLine("Free time");
    }
}