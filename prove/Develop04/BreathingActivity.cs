class Breathing : BaseActivity
{
    public Breathing(string description) : base("Breathing", description)
    {
    }

    public void RunActivity()
    {
        StartActivity();
        RunCountDown("Breath in", 4);
        RunCountDown("Breath out", 6);
    }
}
