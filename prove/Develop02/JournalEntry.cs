using System;
using System.Collections.Generic;

public class JournalEntry

{
    public string _date;
    public string _prompt;
    public string _response;

    string[] _prompts =
    {
        "What was the highlight of your day?",
        "what was something hard today?",
        "What is something you learned?",
        "What is a prompting you received today?",
        "What is something you hope to accomplish in the future?"
    };

    public void CreateJournalEntry()
    {
        Random _random = new Random();
        _date = DateTime.Now.ToShortDateString();

        int randomIndex = _random.Next(_prompts.Length);
        _prompt = _prompts[randomIndex];

        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
        
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}, {_response}");
    }

    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }

    public void Upload(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response; 
    }
}