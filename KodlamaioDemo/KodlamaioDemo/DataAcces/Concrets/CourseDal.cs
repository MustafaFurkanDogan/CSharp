using KodlamaioDemo.DataAcces.Abstracts;
using KodlamaioDemo.Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAcces.Concrets
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;    
        public CourseDal()
        {
            courses = new List<Course>();  
            
            Course course1 = new Course();
            course1.Id = 1;
            course1.CourseName = ".Net";
            course1.CoursePrice = 0;

            Course course2= new Course();
            course2.Id = 2;
            course2.CourseName = "C# + Angular";
            course2.CoursePrice = 0;

            Course course3 = new Course();
            course3.Id = 3;
            course3.CourseName = "Pyton";
            course3.CoursePrice = 0;

            Course course4 = new Course();
            course4.Id = 4;
            course4.CourseName = "Java";
            course4.CoursePrice = 0;

            Course course5 = new Course();
            course5.Id = 5;
            course5.CourseName = "JavaScript";
            course5.CoursePrice = 0;

            Course course6 = new Course();
            course6.Id = 6;
            course6.CourseName = "Java + React";
            course6.CoursePrice = 0;

            Course course7 = new Course();
            course7.Id = 7;
            course7.CourseName = "C#";
            course7.CoursePrice = 0;

            Course course8 = new Course();
            course7.Id = 8;
            course7.CourseName = "Programlamaya Giriş Temel Kurs";
            course7.CoursePrice = 0;




        }
        public void Add(Course addCourse)
        {
            courses.Add(addCourse);
            Console.WriteLine("Course added.");
        }

        public List<Course> CourseGetAll()
        {
            return courses;
            Console.WriteLine("Courses listed.");
        }

        public Course Read(int courseId)
        {
            return courses.Find(course => course.Id==courseId);
        }

        public void Remove(Course removeCourse)
        {
            courses.Remove(removeCourse);
            Console.WriteLine("Course deleted.");

        }

        public void Update(Course updateCourse)
        {
            Course existingCourse = courses.Find(course=>course.Id== updateCourse.Id);

            if (existingCourse != null) 
            {
                existingCourse.CourseName= updateCourse.CourseName;
                Console.WriteLine("Course update.");
            
            }
            else
            {
                Console.WriteLine("Course not found.");
            }
        }
    }
}
