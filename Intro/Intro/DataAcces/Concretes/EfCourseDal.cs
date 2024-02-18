using Intro.DataAcces.Abstracts;
using Intro.Entities;

namespace Intro.DataAcces.Concretes
{
    public class EfCourseDal:ICourseDal
    {
        List<Course> courses;
        public EfCourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "JavaScript";
            course1.Description = ".NET 8 vs..";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java";
            course2.Description = "Java 17 ...";
            course2.Price = 10;

            Course course3 = new Course();
            course3.Id = 1;
            course3.Name = "Pyton";
            course3.Description = "Pyton 3.12...";
            course3.Price = 20;

            courses = new List<Course> { course1, course2, course3 };

        }

        public void Add(Course course)
        {
           courses.Add(course);
        }

        public List<Course> GetAll()
        {
            return courses; 
        }
    }
}
