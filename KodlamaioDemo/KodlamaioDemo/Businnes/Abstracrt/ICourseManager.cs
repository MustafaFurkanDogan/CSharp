using KodlamaioDemo.Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Businnes.Abstracrt
{
    public interface ICourseManager
    {
        void Add(Course course);
        void Remove(Course course); 
        void Update(Course course); 
    }
}
