using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Cyber Soc";
        job1._company = "Arza";
        job1._startYear = 2022;
        job1._endYear = 2024;  

        Job job2 = new Job();
        job2._jobTitle = "Radio";
        job2._company = "Ricks";
        job2._startYear = 2024;
        job2._endYear = 2026;  

        Console.WriteLine($"First comapny: {job1._company}");
        Console.WriteLine($"Second company: {job2._company}");

        job1.Display();
        job2.Display();
    }
}