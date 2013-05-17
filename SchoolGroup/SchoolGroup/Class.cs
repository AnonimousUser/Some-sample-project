using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolGroup
{
    public class Class
    {
        public const int MAX_NUMBER = 30;
        private string className;
        private List<Student> students;

        public Class(string className, List<Student> students)
        {
            if (className.Length == 1)
            {
                throw new ArgumentException("Class must have name with more than one letter!");
            }

            if (className == null)
            {
                throw new NullReferenceException("Class can not have null name!");
            }

            if (className == string.Empty)
            {
                throw new ArgumentException("Class must have non empty name!");
            }

            this.className = className;

            if (students.Count >= MAX_NUMBER)
            {
                throw new ArgumentOutOfRangeException("The number of students in class should be less tha 30");
            }
            if (students==null)
            {
                throw new NullReferenceException("The number of students in can not be null");
            }
            this.students = students;
        }
        
        public List<Student> AddStudent(Student student)
        {
            if (students.Count == 0)
            {
                students = new List<Student>();
            }
            if (this.students.Count < MAX_NUMBER - 1)
            {
                students.Add(student);
            }

            return students;
        }

        public List<Student> RemoveStudent(Student student)
        {
            bool findStudent = false;
            for (int i = 0; i < this.students.Count; i++)
            {
                if ((student.Name == students[i].Name && (student.NumberID == students[i].NumberID)))
                {
                    students.Remove(student);
                    findStudent = true;
                    break;
                }
            }
            if (findStudent == false)
            {
                throw new ArgumentException("No such person in class");
            }
            return students;
        }

        public override string ToString()
        {
            StringBuilder studentsInClass = new StringBuilder();
            studentsInClass.AppendFormat("Class {0}:", this.className);
            studentsInClass.AppendLine();
            for (int i = 0; i < this.students.Count; i++)
            {
                studentsInClass.Append(students[i]);
                studentsInClass.AppendLine();
            }

            return studentsInClass.ToString();
        }
        public string ClassName
        {
            get
            {
                return this.className;
            }
            set
            {
                this.className = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }
    }
}
