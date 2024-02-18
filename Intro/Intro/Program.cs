// See https://aka.ms/new-console-template for more information
using Intro.Businnes;
using Intro.DataAcces.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 10000.5;

//veriables --> camelCase
bool isAuthenicated = true;// false

Console.WriteLine(message1);

//condition
if (isAuthenicated)
{
    Console.WriteLine("Buton--> Hoşgeldin Furkan"); 
}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap");
}

string[] loans = {"Kredi1" , "Kredi2" , "Kredi3" , "Kredi4" , "Kredi5" , "Kredi6" };//dbden gelecek
//string[] loans1 = new string[6];
    
    //start      condition      //increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}







CourseManager courseManager = new(new DapperCourseDal());
List <Course>courses1 = courseManager.GetAll();

for (int i = 0; i < courses1.Count; i++)
{
    Console.WriteLine(courses1[i].Name + " / " + courses1[i].Price);
}






Console.WriteLine("Kod bitti");

IndividualCustomer customer1 = new IndividualCustomer(); 
customer1.Id = 1;   
customer1.FirstName = "Furkan";
customer1.LastName = "Doğan";
customer1.NatioanalIdentity = "12345678910";
customer1.CustomerNumber = "1234567891";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.FirstName = "Berra";
customer2.LastName = "Doğan";
customer2.NatioanalIdentity = "12345678911";
customer2.CustomerNumber = "1234567890";

CorporateCustomer customer3 = new CorporateCustomer(); 
customer3.Id = 3;
customer3.Name = "Kodalamaio";
customer3.CustomerNumber = "1234567890"; 
customer3.TaxNumber = "1234567890";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "1234567895";
customer4.TaxNumber = "1234567892";

//Value Types --> int,double,bool...
//Reference Types --> array,class,interface...
  
                //101       //102       //103       //104
BaseCustomer[] customers = { customer1, customer2, customer3,customer4 };
//poliymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

