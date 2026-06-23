class Listing : BaseActivity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you apreciate?",
        "Who have you helped today?",
        "What was the highlight of your day?"
    };

    private Random _random = new Random();

    public Listing(string description)
        : base("Listing", description)
    {
    }

    public void RunActivity()
    {
        StartActivity();

        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.WriteLine("you may begin in:");

        RunCountDown("", 5);

        int count = 0;

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count ++;
        }

        Console.WriteLine();
        Console.WriteLine($"you listed {count} items!");

        EndActivity();
    }
}