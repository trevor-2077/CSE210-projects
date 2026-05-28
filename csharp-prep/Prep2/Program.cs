using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }

        else if (percent >= 80)
        {
            letter = "B";
        }

        else if (percent >= 70)
        {
           letter = "C";
        }

        else if (percent >= 60)
        {
            letter = "D";
        }

        else
        {
             letter = "F";
        }

        Console.WriteLine($"Your grade: {letter}");
    
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
    
        else if (percent < 70)
        {
            Console.WriteLine("Unfortunately you shall not pass! ...Feel free to try again");
        }

        Console.WriteLine("What is your height in inches? ");
        string height = Console.ReadLine();
        int x = int.Parse(height);                  //Missed declaring x an int and () for Parse rather than {}

        if (x > 48 && x < 78)                       // &&, ||, ==, != 
        {
            Console.WriteLine("You may ride");
        }
        else
        {
            Console.WriteLine("Sorry you may not ride");
        }










    }
    
}