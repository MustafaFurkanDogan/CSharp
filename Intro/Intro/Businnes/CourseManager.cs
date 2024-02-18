using Intro.DataAcces.Abstracts;
using Intro.DataAcces.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Businnes
{
    public class CourseManager
    {  //dependency injection
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List< Course> GetAll() {
            // business rules
            
            return _courseDal.GetAll();
        }   
    }
}
