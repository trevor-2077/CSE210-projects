using System;

public class Relationship : TrackableItem
{
    private string _importDate;
    private List<JournalEntry> _journalEntries;

    public Relationship(string name, string frequency, string importDate)
        : base(name, frequency)
    {
        _importDate = importDate;
        _journalEntries = new List<JournalEntry>();
    }

    public void AddJournal(string highlight, string fullStory)
    {
        _journalEntries.Add(new JournalEntry(highlight, fullStory));
    }
    public void DisplayJournalHistory()
    {
        Console.WriteLine($"\n--- Journal History for {_itemName} ---");
        if (_journalEntries.Count == 0) Console.WriteLine("No entries recorded yet.");
        foreach (JournalEntry entry in _journalEntries)
        {
            entry.DisplayEntry();
        }
    }

    public override void DisplayDashboardRow()
    {
        Console.WriteLine($"[PEOPLE] {_itemName} {_frequency}) -> Import Date: {_importDate}. Total Notes: {_journalEntries.Count}");
    }
}