using KodlamaioDemo.Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Businnes.Abstracrt
{
    public interface IInstructorManager
    {
        void Add(Instructor insturactor);
        void Remove(Instructor instructor);
        void Update(Instructor instructor);
        
    }
}
