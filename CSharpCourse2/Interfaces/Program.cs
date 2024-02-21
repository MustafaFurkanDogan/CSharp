using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {   //interfaceler newlenemez
        static void Main(string[] args)
        {
           // IPersonManager customerManager = new CustomerManager();
          

            //IPersonManager employeemanager = new EmployeeManager(); 

             ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());

            Console.ReadLine();
        }
    }
    interface IPersonManager
    { // unimplement operation
        void add();
        void update();
    }

    class CustomerManager : IPersonManager
    {
        public void add()
        {   //Müşteri ekeleme kodaları
            Console.WriteLine(" Customer is added.");
        }

        public void update()
        {
            Console.WriteLine(" Customer is added.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void add()
        {
            
            //Personel ekeleme kodaları
            Console.WriteLine("Employee is added.");
        }

        public void update()
        {
            Console.WriteLine("Employee is uptaded.");
        }
    }

    class InternManager : IPersonManager

    {
        public void add()
        {
            Console.WriteLine("Intern is added.");
        }

        public void update()
        {
            Console.WriteLine("Intern is uptaded.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager) 
        {
            personManager.add();
        
        }
        
    }



}
