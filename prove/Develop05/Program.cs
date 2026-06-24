using System;

class Program
{
    static void Main(string[] args)
    // {
        // BaseGoal myGoal = new BaseGoal();
        // myGoal.SetName();
        // myGoal.SetDescription();
        // myGoal.SetNumberOfPoints();
        // Console.WriteLine(myGoal.GetDisplayString());
        // myGoal.MarkComplete();
        // Console.WriteLine(myGoal.GetDisplayString());

        SimpleGoal myGoal = new SimpleGoal();
        myGoal.CreateGaol();
        Console.WriteLine(myGoal.GetDisplayString());

    // }

    public void SetDescription()
    {
        Console.WriteLine("Enter the description for {_name} goal: ");
        _description = Console.ReadLine(); 
    }

    public void SetNumberOfPoints()
    {
        Console.WriteLine("Enter the points earned for {_name}")
        _numberOfPoints = Console.ReadLine();
    }
}