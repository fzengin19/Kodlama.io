using OOP2;
Console.WriteLine("Hello, World!");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNumber = "23421";
customer1.TcNo = "13425235345";
customer1.Name = "Fatih";
customer1.SurName = "Zengin";


CoorporateCustomer customer2 = new CoorporateCustomer();
customer2.Id = 2;
customer2.CustomerNumber = "12312";
customer2.TaxNumber = "123421221";
customer2.CompanyName = "kodlama.io";

Customer customer3 = new IndividualCustomer();
Customer customer4 = new CoorporateCustomer();


CustomerManager customerManager = new CustomerManager();

customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Add(customer3);
customerManager.Add(customer4);




{
    return;
}
