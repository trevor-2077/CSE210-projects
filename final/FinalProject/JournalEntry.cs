using System;

public class JournalEntry
{
    private string _highlight;
    private string _fullStory;
    private string _dateLogged;

    public JournalEntry(string highlight, string fullStory)
    {
        _highlight = highlight;
        _fullStory = fullStory;
        _dateLogged = DateTime.Now.ToString("MMMM dd, yyyy");
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"[{_dateLogged}] Highlight: {_highlight}");
        Console.WriteLine($"    Story: {_fullStory}\n");
    }
}