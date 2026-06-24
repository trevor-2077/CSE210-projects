
abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;

   

    public BaseGoal()
    {
        _name = "";
        _description = "";
        _status = false;
        _numberOfPoints = 0;
        _goalType = "";
        
    }

    protected void SetName()
    {
        Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
    }
    
    protected void SetNumberOfPoints()
    {
        Console.WriteLine("Enter number of points earned");
        _numberOfPoints = Console.ReadLine();
    }

    protected virtual string GetDisplayString()
    {
        char statusMarker = ' ';
        if (_status)
        {
            statusMarker = 'X';
        }
        return $"[(StatusMarker)] Name: {_name}, Description: {_description} points earned: {_numberOfPoints}";
    }

    public int MarkComplete()
    {
        _status = true;
        return _numberOfPoints;
    }

    public abstract void CreateGaol();
    public abstract void RecordEvent();
}