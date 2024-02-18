using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Delete ");
        }

        public void Update()
        {
            Console.WriteLine("Sql Update ");
        }
    }

    partial class OrecleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Orecle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Orecle Delete");
        }

        public void Update()
        {
            Console.WriteLine("Orecle Update");
        }

    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Delete ");
        }

        public void Update()
        {
            Console.WriteLine("MySql Update ");
        }
    }
}
