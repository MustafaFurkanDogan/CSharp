using KodlamaioDemo.Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAcces.Abstracts
{
    public interface IInstructorDal
    {
        List<Instructor> InsturactorGetAll();
        void Add(Instructor addInstructor);
        void Remove(Instructor removenIstructor);
        void Update(Instructor updateInstructor);
        Instructor Read(int instrucatorId);

    }
}
