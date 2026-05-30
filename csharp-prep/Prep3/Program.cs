using System;

class Program
{
    static void Main(string[] args)
    {


        Random randomGenerator = new Random();
        int win = randomGenerator.Next(1,100);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int x = int.Parse(guess);
        
        while (x != win)
        {
            if (x > win )
            {
                Console.WriteLine("Guess Lower");
            }
            else if (x < win)
            {
                Console.WriteLine("Guess higher");
            }

            Console.Write("What is your next guess? ");
            guess = Console.ReadLine();
            x = int.Parse(guess);
        }

        Console.WriteLine("Congrats you guessed it");
        











        // While Loop
        // string response = "yes";
        // while (response == "yes")
        // {
            // Console.Write("Continue? ");
            // response = Console.ReadLine();
        // }







        // Do While Loop
        // string response1;
        // 
        // do
        // {
            // Console.Write("Continue on? ");
            // response1 = Console.ReadLine();
        // }while (response1 == "yes");            //; at the end of each






        // For Loop
        // for (int i = 3; i <= 43; i = i + 3)     //i++ incriments by one
        // {
            // Console.Write($"{i} ");
        // }








        // Foreach Loop

        // string[] colors = {"Red ", "Green ", "Blue ", "Purple"};

        // foreach(string color in colors)
        // {
            // Console.WriteLine(color);
        // }






        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1,11);
        // Console.WriteLine($"Congrats your random number is {number}");

    }
}