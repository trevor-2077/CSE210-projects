using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        string number = Console.ReadLine();
        int numero = int.Parse(number);
        List<int> numeros = new List<int>();

        while (numero != 0)
        {
            numeros.Add(numero);                    //Capitalize Add
            Console.Write("");
            number = Console.ReadLine();
            numero = int.Parse(number);
           
            
        }
        int sum = numeros.Sum();
        Console.WriteLine($"The Sum is: {sum}");

        double average = numeros.Average();
        Console.WriteLine($"The average is: {average}");

        int largestNumber = numeros.Max();
        Console.WriteLine($"The largest number is: {largestNumber}");
    
    }
}


// Console.WriteLine(words.Count);
// for (int i = 0; i < words.Count; i++)
// {
    // Console.WriteLine(words[i]);
// }
