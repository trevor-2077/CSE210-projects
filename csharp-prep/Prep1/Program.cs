using System;

class Program
{
    static void Main(string[] args)

    {
        Console.Write("How are you today? ");
        string response = Console.ReadLine();
        Console.WriteLine($"{response}");

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your Last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"{lastname}, {firstName} {lastname}");

        
        Console.Write("What is your favorite color? ");
        string favColor = Console.ReadLine();
        Console.WriteLine($"Your favorite color is {favColor}");
        
        Console.Write("What is your favorite number? ");
        double fav = double.Parse(Console.ReadLine());
        fav = fav + 4.3223;
        Console.WriteLine ($"Your favorite number is {fav}");

        if (fav > 8)
        {
            Console.Write("That is correct");
        }

    }
}