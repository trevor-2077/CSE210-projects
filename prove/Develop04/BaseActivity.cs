class BaseActivity
{
    private string _name;
    private string _description;
    public int _duration;
    private DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine(_description);

        Console.Write("How many seconds for this activity? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void RunCountDown(string message, int duration)
    {
        Console.Write($"{message}: ");

        while(duration > 0)
        {
            Console.Write($"{duration--} ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");

        Thread.Sleep(2000);

        Console.WriteLine($"You completed {_duration} seconds of this activity.");

        Thread.Sleep(2000);
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>()
        {
            "|",
            "/",
            "-",
            "\\"
        };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);

            Thread.Sleep(250);

            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine();
    }

}