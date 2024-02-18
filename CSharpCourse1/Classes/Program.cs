using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "Furkan ";
            customer.LastName = "Doğan";
            customer.City = "Konya";
            customer.Id = 1;

            Customer customer2 = new Customer();
            customer2.FirstName = "Berra ";
            customer2.LastName = "Doğan";
            customer2.City = "Konya";
            customer2.Id = 2;

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }
}
