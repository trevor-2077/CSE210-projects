using System;

class Program
{
    static void Main(string[] args)
    {
        List<double> times = new List<double> {9.58, 9.69, 9.72, 9.74, 9.78 }; 
        double smallest = GetSmallestNumber(times);
        Console.WriteLine($"Fastest time: {smallest}");
    }

    static double GetSmallestNumber(List<double> times)
    {
        double smallest = times[0];

        for (int i =1; i < times.Count; i++)
        {
            if (times[i] < smallest)
            {
                smallest = times[i];
            }
        }
        return smallest;
    }
}