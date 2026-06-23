class Breathing : BaseActivity
{
    public Breathing(string description) : base("Breathing", description)
    {
    }

    public void RunActivity()
    {
        StartActivity();
        
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            RunCountDown("Breath in", 4);
            RunCountDown("Breath out", 6);
        }

        EndActivity();
    }
}
