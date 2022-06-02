
AMevzuat aMevzuat = new AMevzuat();
aMevzuat.Kaydet();
aMevzuat.Degerlendir();
{
    return;
}
// abstract classlar newlenemez ama constructor bloğu içerebilir 
// kendisi newlenemiyor olsa dahi kendisinden inherits olan classlar newlendiğinde miras alınan abstract classın constructoru çalışır
abstract class MevzuatBase
{
    protected MevzuatBase()
    {

    }
    public abstract void Degerlendir();
    public void Kaydet()
    {
        Console.WriteLine("Kaydedildi");
    }
}
class AMevzuat : MevzuatBase
{
    public override void Degerlendir()
    {
        Console.WriteLine("A mevzuatına göre değerlendirildi.");
    }
}
  
class CustomerManager
{
    //implemented operations
    public void Add()
    {
        Console.WriteLine("Customer added.");
    }
    public void Delete()
    {
        Console.WriteLine("Customer deleted.");
    }
}

class Customer
{   
    
    //properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}