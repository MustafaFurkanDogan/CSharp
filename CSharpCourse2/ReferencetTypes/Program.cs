using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencetTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //intidecimalifloat,enum,boolean value types
            int sayı1= 10;
            int sayı2 = 20;
            sayı1 = sayı2;
            sayı2= 100;

            Console.WriteLine("Sayı 1: " + sayı1);


            //arrays,class,interface....referance types

            int[] sayılar1 = new int[] { 1, 2, 3, };
            int[] sayılar2 = new int[] {10,20,30};

            sayılar1 = sayılar2;
            sayılar2[0] = 1000;

            Console.WriteLine("Sayılar1[0] =" + sayılar1[0]);   
            

            Person person1 = new Person();
            Person person2 = new Person();  
            person1.FirstName = "Furkan";

            person2 = person1;
            person1.FirstName = "Berra";

            Console.WriteLine(person2.FirstName);

            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Gilbert";

            Employee employee = new Employee();

            Person person3 = customer;




                                //  box
            Console.WriteLine(((Customer)person3).CreditCardNumber);  
            
            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
                             // customer person yazılabilir
           
            Console.ReadLine(); 
            
        }
    }

    class Person 
    {
        public int  Id { get; set; }
        public string FirstName { get; set; }    
        public string LastName { get; set; } 
    }

    class Customer : Person 
    {
        public string CreditCardNumber { get; set; }
        
    }

    class Employee : Person 
    {
    
    
    
    
    }

    class PersonManager 
    {

        public void Add(Person person)
        {


            Console.WriteLine(person.FirstName);
            
        
        
        
        }   
    
    
    
    
    
    }
}
