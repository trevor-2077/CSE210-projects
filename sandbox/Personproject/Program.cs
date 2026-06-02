class Program
{
    public static void Main(string[]args)
    {
        Police myPoliceMan = new Police("Gun", "Robert", "Bob", 43, 187);

        Console.WriteLine(myPoliceMan(GetmyPesonInformation()));
    }
}
