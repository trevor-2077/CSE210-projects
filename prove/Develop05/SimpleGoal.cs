class SimpleGoal : BaseGoal
{
    public SimpleGoal() : base("SimpleGoal") {}

    public SimpleGoal(string name, string description, int points, bool status)
        : base("SimpleGoal",name,description,points,status) {}

    public override int RecordEvent()
    {
        if (!Status)
        {
            Status = true;
            Console.WriteLine($"Congratulations! You earned {NumberOfPoints} points!");
            return NumberOfPoints;
        }
        Console.WriteLine("This goal has already been completed");
        return 0;
    }
}