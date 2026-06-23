using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. Quit");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Breathing myBreathingActivity =
                new Breathing("This will help you to breathe better");

            myBreathingActivity.RunActivity();
        }

        else if (choice == "2")
        {
            Reflection myReflectionActivity =
                new Reflection("This will help you to reflect on your day");
            myReflectionActivity.RunActivity();
        }

        else if (choice == "3")
        {
            Listing myListingActivity =
                new Listing("List as many things the come to mind regarding");
            myListingActivity.RunActivity();
        }
    }
}