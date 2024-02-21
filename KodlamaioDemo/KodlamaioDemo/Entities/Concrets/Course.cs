using KodlamaioDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Entities.Concrets
{
    public class Course : BaseEntities
    {
        public string CourseName { get; set; }
        public int CoursePrice { get; set; }   
    }
}
