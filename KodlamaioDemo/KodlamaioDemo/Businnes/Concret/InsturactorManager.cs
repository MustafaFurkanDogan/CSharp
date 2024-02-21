using KodlamaioDemo.Businnes.Abstracrt;
using KodlamaioDemo.Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Businnes.Concret
{
    public class InsturactorManager : IInstructorManager
    {
        private Instructor _instuructorManager;
        public InsturactorManager(IInstructorManager instructorManager)
        {
            _instuructorManager = (Instructor)instructorManager;
        }
        public void Add(Instructor insturactor)
        {
            Console.WriteLine("Insturactor added.");
        }

        public void Remove(Instructor instructor)
        {
            Console.WriteLine("Insturactor was remove.");
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine("Insturactor uptaded.");
        }
    }
}
