using System;

class Menu
{
    public static int DisplayMenu()
    {
        Console.WriteLine("""
        Please select on of the following options:
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit 
        What would you like to do?
        """);
        string menuInput = Console.ReadLine();
        int redirect = int.Parse(menuInput);
        return redirect;
    }
}