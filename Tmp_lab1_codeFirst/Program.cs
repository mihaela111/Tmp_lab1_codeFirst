using System;
using System.Linq;

namespace Tmp_lab1_codeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolContext();
           // Add new Students
            context.AddStudent("Marinescu");
            context.AddStudent("Popa");
            context.AddStudent("Ioan");
            context.AddStudent("Grigore");
            context.DisplayStudents();
            // Add new Courses
            context.AddCourse("Data Structure");
            context.AddCourse("Java");
            context.AddCourse("Algorithms");
            context.AddCourse(".NET");
            context.DisplayCourses();
            //Console.WriteLine("Update first student:");
            //context.UpdateStudent(context.Students.First().StudentName, "New student");
            //context.DisplayStudents();
            //Console.WriteLine("Update first course:");
            //context.UpdateCourse(context.Courses.First().CourseName, "New course");
            //context.DisplayCourses();
            //Console.WriteLine("Delete first student:");

            //context.DeleteStudent(context.Students.First().StudentName);
            //context.DisplayStudents();
            //Console.WriteLine("Delete first course:");
            //context.DeleteCourse(context.Courses.First().CourseName);
            //context.DisplayCourses();
            //Console.ReadLine();
        }
    }
}
