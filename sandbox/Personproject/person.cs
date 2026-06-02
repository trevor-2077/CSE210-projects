class Person
{
    private string firstName;

    private string lastName;

    private int age;

    private int weight;

    public Person(string firstName, string lastname, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _weight = weight;
    }

    public string GetPersonInfromation()
    {
        return $"Name: {_firstname} {_lastname}, {age}, weight: {_weight}"'
    }
}