

using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapter;
using InterfaceAbstractDemo.Concrete;
//using InterfaceAbstractDemo.Entities; 


BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
baseCustomerManager.Save(new Customer { DateOfBirth= new DateTime(2000,9,11),FirstName="Fatih",LastName="Zengin",NationalityId="23535553"});
Console.ReadLine();
{
    return;
}
