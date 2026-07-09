
abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;

    public string Name => _name;
    public string Description => _description;
    public string GoalType => _goalType;
    public int NumberOfPoints => _numberOfPoints;
    public bool Status 
    { 
        get => _status;
        set => _status = value; 
    }

    public BaseGoal(string goalType)
    {
        _name = "";
        _description = "";
        _status = false;
        _numberOfPoints = 0;
        _goalType = "";    
    }

    public BaseGoal(string goalType, string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
        _goalType = goalType;
    }

    public virtual void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.WriteLine($"Enter the description for the '{_name}' goal: ");
        _description = Console.ReadLine();

        Console.WriteLine("Enter the points association with this goal: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    public virtual string GetDisplayString()
    {
        char statusMarker = _status ? 'X' : ' ';
        return $"[{statusMarker}] {_name} {_description}";
    }

    public abstract int RecordEvent();

    public virtual string GetStringRepresentation()
    {
        return $"{_goalType}:{_name},{_description},{_numberOfPoints},{_status}";
    }
}    
