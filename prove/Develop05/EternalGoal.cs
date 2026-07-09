class EternalGoal : BaseGoal
{
    public EternalGoal() : base("EternalGoal") {}

    public EternalGoal(string name, string description, int points, bool status)
        : base("EternalGoal", name, description, points, status) {}

    public override int RecordEvent()
    {
        Console.WriteLine($"Awesome! You earned {NumberOfPoints} points!");
        return NumberOfPoints;
    }
}