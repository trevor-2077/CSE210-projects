using System;
public class Program
{
    public static void Main(string[] args)
    {
    DashboardManager dashboard = new DashboardManager();
    Scheduler scheduler = new Scheduler();

    Console.WriteLine("=== QUALITY V QUANTITY SETUP ===");

    Console.Write("Daily task name: ");
    string dailyName = Console.ReadLine();
    Console.Write("Daily target amount: ");
    int.TryParse(Console.ReadLine(), out int dailyTarget);
    RecurringTask dailyTask = new RecurringTask(dailyName, "Daily", dailyTarget);
    dashboard.AddItem(dailyTask);

    Console.Write("\nWeekly task name: ");
    string weeklyName = Console.ReadLine();
    Console.Write("Weekly target amount: ");
    int.TryParse(Console.ReadLine(), out int weeklyTarget);
    RecurringTask weeklyTask = new RecurringTask(weeklyName, "Weekly", weeklyTarget);
    dashboard.AddItem(weeklyTask);

    Console.Write("\nPerson to track: ");
    string personName = Console.ReadLine();
    Console.Write("Important date: ");
    string importantDate = Console.ReadLine();
    Relationship relation = new Relationship(personName, "Weekly", importantDate);
    dashboard.AddItem(relation);

    Console.Write("\nSchedule an activity: ");
    string activity = Console.ReadLine();
    Console.Write("Day: ");
    string day = Console.ReadLine();
    Console.Write("Time: ");
    string time = Console.ReadLine();
    scheduler.AddEvent(activity, day, time);

    bool running = true;
    while (running)
        {
        Console.Clear();

        dashboard.ShowDashboard();

        Console.WriteLine();
        Console.WriteLine("============== MENU ==============");
        Console.WriteLine("1. Log Task Progress");
        Console.WriteLine("2. Add Journal Entry");
        Console.WriteLine("3. View Journal History");
        Console.WriteLine("4. View Schedule");
        Console.WriteLine("5. Exit");
        Console.Write("Choice: ");

        switch (Console.ReadLine())
        {
            case "1":
                LogTaskProgress(dailyTask, weeklyTask);
                break;

            case "2":
                AddJournalEntry(relation);
                break;

            case "3":
                relation.DisplayJournalHistory();
                Pause();
                break;

            case "4":
                ViewSchedule(scheduler);
                break;

            case "5":
                running = false;
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }

    private static void LogTaskProgress(RecurringTask dailyTask, RecurringTask weeklyTask)
    {
        Console.Write("Amount completed: ");

        if (int.TryParse(Console.ReadLine(), out int amount))
        {
            dailyTask.LogProgress(amount);
            weeklyTask.LogProgress(amount);
        }
        Pause();
    }

    private static void AddJournalEntry(Relationship relation)
    {
        Console.Write("Day Highlight: ");
        string highlight = Console.ReadLine();
        Console.Write("Full Story: ");
        string story = Console.ReadLine();
        relation.AddJournal(highlight, story);
        Pause();
    }

    private static void ViewSchedule(Scheduler scheduler)
    {
        Console.Write("Enter a day: ");
        string day = Console.ReadLine();
        scheduler.ViewScheduleForDay(day);
        Pause();
    }

    private static void Pause()
    {
        Console.WriteLine();
        Console.Write("Press Enter to continue...");
        Console.ReadLine();
    }
}