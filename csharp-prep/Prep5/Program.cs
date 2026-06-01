using System;

class Program
{
    static void Main(string[] args)
    {
    DisplayWelcome();
    string name = PromptUserName();
    int favNumber = PromptUserNumber();
    PromptUserBirthYear(out int BirthYr);
    string resultMessage = SquareNumber(favNumber, name);
    Console.WriteLine(resultMessage);
    string ageMessage = AgeThisYear(BirthYr, name);
    Console.WriteLine(ageMessage);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name; 
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string favorito = Console.ReadLine();
        int favNumber = int.Parse(favorito);
        return favNumber; 
    }

    static void PromptUserBirthYear(out int BirthYr)
    {
        Console.Write("What year were you born? ");
        string nascimento = Console.ReadLine();
        BirthYr = int.Parse(nascimento);                //Not int Birthyr
    }

    static string SquareNumber(in int favNumber, string name)
    {
        return $"{name}, the square of your number is: {favNumber * favNumber}";
    }
    
    static string AgeThisYear(int BirthYr, string name)
    {
        return $"{name}, you will turn {2026 - BirthYr} this year";
    }











        // try
        // {
                // Attempt to divide by zero
            // int numerator = 10;
            // int denominator = 0;
            // int result = numerator / denominator;
            // Console.WriteLine("Result: " + result);
        // }
        // catch (DivideByZeroException ex)  //Handle only divide by 0 exception
        // {
            // Console.WriteLine("Error: Cannot divide by zero.");
            // Console.WriteLine("Exception message: " + ex.Message);
        // }
        // catch (Exception ex)  // Catches all other exceptions
        // {
            // Console.WriteLine("Error: Exception Occurred");
            // Console.WriteLine("Exception message: " + ex.Message);
        // }
        // finally
        // {
            // Console.WriteLine("This block always executes, regardless of exceptions.");
          // }
}