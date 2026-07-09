using System.Globalization;
using System.Net;

class ChecklistGoal : BaseGoal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonusPoints;

    public int AmountCompleted => _amountCompleted;
    public int TargetAmount => _targetAmount;
    public int BonusPoints => _bonusPoints;

    public ChecklistGoal() : base("ChecklistGoal") {}

    public ChecklistGoal(string name, string description, int points, bool status, int amountCompleted, int targetAmount, int BonusPoints)
        : base("ChecklistGoal", name, description, points, status)
    {
        _amountCompleted = amountCompleted;
        _targetAmount = targetAmount;
        _bonusPoints = BonusPoints;
    }

    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _targetAmount = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the bonus points amount for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        _amountCompleted = 0;
    }
    public override string GetDisplayString()
    {
         char statusMarker = Status ? 'X' : ' ';
         return $"[{statusMarker}] {Name} ({Description}) -- Currently completed: {_amountCompleted}/{_targetAmount}";
    }
    public override int RecordEvent()
    {
        if (Status)
        {
            Console.WriteLine("This checklist goal is already completely finished");
            return 0;
        }

        _amountCompleted++;
        int pointsEarned = NumberOfPoints;

        if (_amountCompleted >= _targetAmount)
        {
            Status = true;
            pointsEarned += _bonusPoints;
            Console.WriteLine($"Way to go! you hit your target {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine($"Congrats you earned {NumberOfPoints} points!");            
        }

        return pointsEarned;
    }

    public override string GetStringRepresentation()
    {
        return $"{GoalType}:{Name},{Description},{NumberOfPoints},{Status},{_amountCompleted},{_targetAmount},{_bonusPoints}";
    }
}