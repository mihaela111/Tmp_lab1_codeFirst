using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tmp_lab1_codeFirst
{
    public class SchoolContext : DbContext
    {//definire model
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses {get; set;}

        /*definire conexiune
         pe ce server sa facem db */

        protected override void OnConfiguring(
  DbContextOptionsBuilder optionsBuilder)
        {
            //ar fi trebuit sa mearga si daca punem "."
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SVF1EHF\SQLEXPRESS; Database=SchoolDB;Trusted_Connection=True;");

        }
        //guid= global /////identifier
        public void AddStudent(string name)
        {
            var student = new Student()

            {
                StudentName = name
            };
            Students.Add(student);
            SaveChanges();
        }

        internal void UpdateStudent(object name, string v)
        {
            throw new NotImplementedException();
        }

        public void AddCourse(string courseName)
        {
            var course = new Course()
            {
                CourseName = courseName
            };
            Courses.Add(course);
            SaveChanges();
        }

        public void UpdateStudent(string oldName, string newName)
        {
            var std = Students.Where(n => n.StudentName.Equals(oldName)).FirstOrDefault();
            std.StudentName = newName;
            Students.Update(std);
            SaveChanges();
        }

        public void UpdateCourse(string oldName, string newName)
        {
            var course = Courses.Where(n => n.CourseName.Equals(oldName)).FirstOrDefault();
            course.CourseName = newName;
            Courses.Update(course);
            SaveChanges();
        }

        public void DeleteStudent(string name)
        {
            var std = Students.Where(n => n.StudentName.Equals(name)).FirstOrDefault();
            std.StudentName = name;
            Students.Remove(std);
            SaveChanges();
        }

        public void DeleteCourse(string name)
        {

            var course = Courses.Where(n => n.CourseName.Equals(name)).First();
            course.CourseName = name;
            Courses.Remove(course);
            SaveChanges();
        }

        public void DisplayStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine("{0} - {1}", student.StudentID, student.StudentName);
            }
            Console.WriteLine();
        }

        public void DisplayCourses()
        {
            foreach (var course in Courses)
            {
                Console.WriteLine("{0} - {1}", course.CourseID, course.CourseName);
            }
            Console.WriteLine();
        }


    }
}
