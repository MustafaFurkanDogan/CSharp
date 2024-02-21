using KodlamaioDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Entities.Concrets
{
    public class Instructor :BaseEntities
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Background { get; set; }
        

    }
}
