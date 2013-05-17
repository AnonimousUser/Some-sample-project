using System;
using System.Collections.Generic;
namespace SchoolGroup
{
    class School
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ivan Ivanov", 98);
            List<Student> students = new List<Student>();
            students.Add(student);
            Class Maths = new Class("Math", students);
            Console.WriteLine(student.Name);
            Console.WriteLine(Maths);
        }
    }
}
