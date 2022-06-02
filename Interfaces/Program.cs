
using Interfaces;
//Main.InterfacesIntro();
//Demo();
ICustomerDal[] customerDals = new ICustomerDal[]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal(),
    new MySqlCustomerDal()
};




{

    return;
}
class Main
{
    public static void InterfacesIntro()
    {
        PersonManager personManager = new PersonManager();
        personManager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Address = "Ankara" });

        Student student = new Student { Id = 1, FirstName = "Fatih", LastName = "Zengin", Departmant = "Computer Sciences" };
        personManager.Add(student);
    }
    public void Demo()
    {
        CustomerManager customerManager = new CustomerManager();

        customerManager.Add(new SqlServerCustomerDal());
        customerManager.Add(new OracleCustomerDal());
    }
}

interface IPerson
{   // shared features
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }

}

// inherits - class --------- implements - interface
class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }

}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }

}
class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName + " Added.");
    }
}