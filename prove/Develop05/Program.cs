using System;
using System.Drawing;
using System.Runtime.CompilerServices;

class Program
{
    private static List<BaseGoal> _goals = new List<BaseGoal>();
    private static int _score = 0;
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine();
            // DisplayPlayerStatus();??
            Console.WriteLine("""
            Menu Options:
            1. Create New Goal
            2. List Goals
            3. Save Goals
            4. Load Goals
            5. Record Event
            6. Quit
            Select a choice from the menu:
            """ );
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateNewGoalMenu();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoalFile();
                    break;
                case "4":
                    LoadGoalsFile();
                    break;
                case "5":
                    RecordGoalEvent();
                    break;
                case "6":
                    running = false;
                    break;
            }

        }
    }
    private static void CreateNewGoalMenu()
    {
        Console.WriteLine("""
        The types of goals are:
        1. Simple Goal
        2. Eternal Goal
        3. Checklist Goal
        Which type of goal would you like to create?
        """);

        string typeChoice = Console.ReadLine();
        BaseGoal newGoal = null;

        switch(typeChoice)
        {
            case "1": newGoal = new SimpleGoal(); break;
            case "2": newGoal = new EternalGoal(); break;
            case "3": newGoal = new ChecklistGoal(); break;
        }
        newGoal.CreateGoal();
        _goals.Add(newGoal);
    }

    private static void ListGoals()
    {
        Console.WriteLine("The goals are:");
        if (_goals.Count == 0)
        {
            Console.WriteLine(" (No goals created yet) ");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
        }
    }

    private static void RecordGoalEvent()
    {
        ListGoals();
        if (_goals.Count == 0) return;

        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) -1;

        if (index >= 0 && index < _goals.Count)
        {
            int pointsEarned = _goals[index].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Your score in now {_score}.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    private static void SaveGoalFile()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (BaseGoal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goal saved successfully!");
    }

    private static void LoadGoalsFile()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);

        if (lines.Length > 0)
        {
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] mainParts = line.Split(':');

                string type = mainParts[0];
                string[] dataParts = mainParts[1].Split(',');

                string name = dataParts[0];
                string description = dataParts[1];
                int points = int.Parse(dataParts[2]);
                bool status = bool.Parse(dataParts[3]);

                if (type == "SimpleGoal")
                {
                    _goals.Add(new SimpleGoal(name, description, points, status));
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, description, points, status));
                }
                else if (type == "ChecklistGoal")
                {
                    int amountCompleted = int.Parse(dataParts[4]);
                    int targetAmount = int.Parse(dataParts[5]);
                    int BonusPoints = int.Parse(dataParts[6]);
                    _goals.Add(new ChecklistGoal(name, description, points, status, amountCompleted, targetAmount, BonusPoints));
                }
            }
        }
        Console.WriteLine("Goals successfully loaded!");
    }
}