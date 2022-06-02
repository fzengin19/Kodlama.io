
Person[] persons = new Person[3]
{
    new Person
    {
        FirstName="Fatih"
    },new Customer
    {
        FirstName="Engin"
    },new Student
    {
        FirstName="Salih"
    }
};

foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}
{
    return;
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer:Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}