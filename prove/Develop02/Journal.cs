using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    List<JournalEntry> _journalEntries = new List<JournalEntry>();

    public void AddJournalEntry(JournalEntry journalEntry)
    {
        _journalEntries.Add(journalEntry);
    }

    public void DisplayJournal()
    {
        foreach (JournalEntry journalEntry in _journalEntries)
        {
            journalEntry.DisplayJournalEntry();
        }
    }
    public void Upload()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        _journalEntries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");
            if (parts.Length >= 3)
            {
                string date = parts [0];
                string prompt = parts [1];
                string response = parts[2];

                JournalEntry loadedEntry = new JournalEntry();

                loadedEntry.Upload(date, prompt, response);

                _journalEntries.Add(loadedEntry);
            }
        Console.WriteLine("Journal loaded successfully");
        }
    }
     public void Save()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry journalEntry in _journalEntries)
            {
                string fileLine = journalEntry.CreateFileSystemString();
                outputFile.WriteLine(fileLine);
            }
        }
        Console.WriteLine("Journal save successfully");
    }
}