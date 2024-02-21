using KodlamaioDemo.Businnes.Abstracrt;
using KodlamaioDemo.Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Businnes.Concret
{
    public class CourseManager : ICourseManager
    {
        private  ICourseManager _courseManager; 
        public CourseManager(ICourseManager courseManager)
        {

            _courseManager = courseManager; 

        }
        public void Add(Course course)
        {
            Console.WriteLine("Category added.");
        }

        public void Remove(Course course)
        {
             Console.WriteLine("Category was remove.");
        }

        public void Update(Course course)
        {
            Console.WriteLine("Category uptaded.");
        }
    }
}
