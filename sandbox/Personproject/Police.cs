class Police: Person      //class then parent  
{
    private string weapons;
    public Police(string weapons, string firstName, 
    string lastName, int age, int weight)
    : base (firstName, lastName, age, weight)
    {
        _weapons = weapons
    }
}