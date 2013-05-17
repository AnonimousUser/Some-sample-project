using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolGroup;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolGroupTest
{
    [TestClass]
    public class ClassTest
    {
        [TestMethod]
        public void TestClassConstructorName()
        {
            string name = "Biology";
            List<Student> students = new List<Student>();
            Student Ivan = new Student("Ivan", 14);
            Student Petya = new Student("Petya", 1234);
            students.Add(Ivan);
            students.Add(Petya);
            Class Biology = new Class(name, students);
            Assert.AreEqual(Biology.ClassName, "Biology");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestClassConstructorNullName()
        {
            List<Student> students = new List<Student>();
            Student Ivan = new Student("Ivan", 14);
            Student Petya = new Student("Petya", 1234);
            students.Add(Ivan);
            students.Add(Petya);
            Class maths = new Class(null, students);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentConstructorEmptyName()
        {
            List<Student> students = new List<Student>();
            Student Ivan = new Student("Ivan", 14);
            Student Petya = new Student("Petya", 1234);
            students.Add(Ivan);
            students.Add(Petya);
            Class maths = new Class("", students);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentConstructorOneLetterName()
        {
            List<Student> students = new List<Student>();
            Student Ivan = new Student("Ivan", 14);
            Student Petya = new Student("Petya", 1234);
            students.Add(Ivan);
            students.Add(Petya);
            Class maths = new Class("M", students);;
        }
        [TestMethod]
        public void TestClassConstructorStudentsList()
        {
            List<Student> students = new List<Student>();
            Student Ivan = new Student("Ivan", 14);
            Student Petya = new Student("Petya", 1234);
            students.Add(Ivan);
            students.Add(Petya);
            Class maths = new Class("Math", students);
            Assert.AreEqual(students, maths.Students);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestClassConstructorStudents()
        {
            List<Student> students = new List<Student>();
            Student Ivan = new Student("Ivan", 14);
            Student Petya = new Student("Petya", 1234);
            students.Add(Ivan);
            students.Add(Petya);
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            students.Add(new Student("Name", 678));
            Class maths = new Class("Math", students); 
        }

        [TestMethod]
        public void TestAddStudentMethod()
        {
            List<Student> students = new List<Student>();
            Student Ivan = new Student("Ivan", 14);
            Student Petya = new Student("Petya", 1234);
            students.Add(Ivan);
            students.Add(Petya);
            Class Maths = new Class("Maths", students);
            Maths.AddStudent(new Student("Kiril", 34));
            students.Add(new Student("Kiril", 34));
            Assert.AreEqual(Maths.Students, students);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestAddStudentMethodToNullList()
        {
            Class Maths = new Class("Maths", null);
            
        }

        [TestMethod]
        public void TestAddStudentMethodToEmptyList()
        {
            List<Student> students = new List<Student>();
            Class Maths = new Class("Maths", students);
            Student Kiril=new Student("Kiril", 34);
            Maths.AddStudent(Kiril);
            students.Add(Kiril);
            Assert.AreEqual(Maths.Students[0], Kiril);
        }

        [TestMethod]
        public void TestRemoveStudentMethod()
        {
            List<Student> students = new List<Student>();
            Student Ivan = new Student("Ivan", 14);
            Student Petya = new Student("Petya", 1234);
            students.Add(Ivan);
            students.Add(Petya);
            Class Maths = new Class("Maths", students);
            Maths.RemoveStudent(Petya);
            students.Remove(Petya);
            Assert.AreEqual(Maths.Students, students);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemoveStudentMethodNotExixtingStudent()
        {
            List<Student> students = new List<Student>();
            Student Ivan = new Student("Ivan", 14);
            Student Petya = new Student("Petya", 1234);
            Student Kircho = new Student("Kircho", 134);
            students.Add(Ivan);
            students.Add(Petya);
            Class Maths = new Class("Maths", students);
            Maths.RemoveStudent(Kircho);
        }

        [TestMethod]
        public void TestStudentToStringNumber()
        {
            List<Student> students = new List<Student>();
            Student Ivan = new Student("Ivan", 14);
            students.Add(Ivan);
            Class Maths = new Class("Maths", students);
            StringBuilder classToString = new StringBuilder();
            classToString.Append("Class Maths:");
            classToString.AppendLine();
            classToString.Append("NumberID: 14, Name: Ivan");
            classToString.AppendLine();
            Assert.AreEqual(Maths.ToString(),classToString.ToString() );
        }

        [TestMethod]
        public void TestClassSetName()
        {
            List<Student> students = new List<Student>();
            Student Ivan = new Student("Ivan", 14);
            Student Petya = new Student("Petya", 1234);
            students.Add(Ivan);
            students.Add(Petya);
            Class Maths = new Class("Maths", students);
            Maths.ClassName = "OtherMaths";
            Assert.AreEqual(Maths.ClassName, "OtherMaths");
        }

        [TestMethod]
        public void TestClassSetStudents()
        {
            List<Student> students = new List<Student>();
            Student Ivan = new Student("Ivan", 14);
            Student Petya = new Student("Petya", 1234);
            students.Add(Ivan);
            students.Add(Petya);
            Class Maths = new Class("Maths", students);
            List<Student> otherStudents = new List<Student>();
            Student Ivanka = new Student("Ivanka", 140);
            Student Petka = new Student("Petka", 234);
            otherStudents.Add(Ivanka);
            otherStudents.Add(Petka);
            Maths.Students = otherStudents;
            Assert.AreEqual(Maths.Students[0], Ivanka);
        }
    }
}