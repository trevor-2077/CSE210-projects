using System;

class Program
{
    static void Main(string[] args)
    {
        // BaseActivity myActivity = new BaseActivity("Breathing", "This will help you breath");
        // myActivity.StartActivity();
        // myActivity.RunCountDown("Breath in", 10);



        Breathing myBreathingActivity = new Breathing("This will help you breath better");
        myBreathingActivity.RunActivity();
    }
}