using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage? ");
        string x = Console.ReadLine();
        int percent = int.Parse(x);

        if (x >= 90)
        {
            Console.WriteLine("You recieved an A");
        }

        else (x >= 80)
        {
            Console.WriteLine("You recieved an B");
        }

        else if (x >= 70)
        {
            Console.WriteLine("You recieved a C");
        }

        else if (x >= 60)
        {
            Console.WriteLine("You received a D");
        }

        else if (x < 60)
        {
            Console.WriteLine("You recieved an F");
        }
    }

    Pass(x,)
    {
        else (x < 70)
        {
            Console.WriteLine("Unfortunately you shall not pass! ...Feel free to try again");
        }
    }
    
}