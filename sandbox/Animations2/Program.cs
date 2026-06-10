using System.Diagnostics.CodeAnalysis;

class Program
{
    public static void Main(string[]args)
    {
    int count = 15;
    DateTime now = DateTime.Now;
    DateTime endTime = NotNullWhenAttribute.AddSeconds(count);

        while(DateTime.Now < endTime)
        {
            Console.Write($"{count --,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    
      
        Console.Clear();
        Console.CursorVisible = false;
        for (int i = 0; i < 20; i++)
        {
            Console.Write("+");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");

        }
        Console.CursorVisible = true;
    

        string animationString = "\\-|/";
        DateTime now = DateTime.Now;
        DateTime entTime = now.AddSeconds(10);
        Console.WriteLine(""+now.ToString(""));
        int index = 0;

        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ %animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");

        }




        for (int i = 0; i < 20; i++)
        {
            Console.Write(animationString[i % animationString.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }
}
