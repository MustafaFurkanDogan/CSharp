using KodlamaioDemo.Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAcces.Abstracts
{
    public interface ICourseDal
    {
        List<Course> CourseGetAll();
        void Add(Course addCourse);
        void Remove(Course removeCourse);
        void Update(Course updateCourse);

        Course Read(int courseId);
    }
}
