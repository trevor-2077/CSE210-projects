using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Poverbs", 3, 5, 6);

        Scripture scripture = new Scripture(
            ref1, 
            "Trust in the Lord with all thine heart and lean not unto thine own understanding."
            );

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram ended.");
    }
}