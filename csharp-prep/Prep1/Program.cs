using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?");
        string firstName;
        firstName = Console.ReadLine();

        Console.Write("What is your Last name?");
        string lastname = Console.ReadLine();

        Console.WriteLine($"{lastname}, {firstName} {lastname}");

        int x =10;

        if(x == 10)
        {
           Console.WriteLine("10");  
        }

        else if (x == 20)
        {
            Console.WriteLine("bwtyer");
        }
        else
        {
            
        }

    }
}