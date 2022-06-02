

IPersonManager customerManager = new CustomerManager();
IPersonManager emplooyeManager = new EmplooyeManager();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(customerManager);
projectManager.Add(emplooyeManager);
projectManager.Add(new InternManager());

{
    return;
}

interface IPersonManager
{
    //unimplemented operation
    void Add();
    void Update();
}

//inherits - class -------- implements - interface

class CustomerManager:IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Müşteri eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri güncellendi.");
    }
}

class EmplooyeManager:IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Personel eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Personel güncellendi.");
    }
}
class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer güncellendi.");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}