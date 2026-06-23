class Reflection : BaseActivity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you did something really difficult",
        "When did you help someone in need?",
        "What is a goal you are glad you accomplished today?"
    };

    private List<string> _questions = new List<string>()
    {
        "Why was that meaningful to you?",
        "How did you feel afterwards?",
        "What did you learn about yourself from this experience?"
    };

    private Random _random = new Random();

    public Reflection(string description)
        :base("Reflection", description)
    {
    }

    public void RunActivity()
    {
        StartActivity();

        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.WriteLine("Press Enter when you think of something");
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = _questions[_random.Next(_questions.Count)];

            Console.WriteLine();
            Console.WriteLine(question);

            ShowSpinner(5);
        }
        EndActivity();
    }
}