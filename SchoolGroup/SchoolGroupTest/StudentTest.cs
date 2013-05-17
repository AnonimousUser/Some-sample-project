using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolGroup;

namespace SchoolGroupTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestStudentConstructorName()
        {
            string name = "Biliana Georgieva";
            int idNumber = 1;
            Student student = new Student(name, idNumber);
            Assert.AreEqual(student.Name, "Biliana Georgieva");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestStudentConstructorNullName()
        {
            Student student = new Student(null, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentConstructorEmptyName()
        {
            Student student = new Student("", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentConstructorOneLetterName()
        {
            Student student = new Student("I", 10);
        }

        [TestMethod]
        public void TestStudentConstructorIDnumber()
        {
            string name = "Biliana Georgieva";
            int idNumber = 1;
            Student student = new Student(name, idNumber);
            Assert.AreEqual(student.NumberID, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentConstructorIDnumberNegative()
        {
            Student student = new Student("Biliana", -23);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentConstructorIDnumberBiggerThanMax()
        {
            Student student = new Student("Biliana", 100000);
        }
        
        [TestMethod]
        public void TestStudentSetName()
        {
            string name = "Biliana Georgieva";
            int idNumber = 1;
            Student student = new Student(name, idNumber);
            student.Name = "Ivan Ivanov";
            Assert.AreEqual(student.Name, "Ivan Ivanov");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentSetEmptyName()
        {
            string name = "Biliana Georgieva";
            int idNumber = 1;
            Student student = new Student(name, idNumber);
            student.Name = "";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentSetEmptyNameSpace()
        {
            string name = "Biliana Georgieva";
            int idNumber = 1;
            Student student = new Student(name, idNumber);
            student.Name = " ";
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestStudentSetNullName()
        {
            string name = "Biliana Georgieva";
            int idNumber = 1;
            Student student = new Student(name, idNumber);
            student.Name = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentSetOneLetterName()
        {
            string name = "Biliana Georgieva";
            int idNumber = 1;
            Student student = new Student(name, idNumber);
            student.Name = "B";
        }

        [TestMethod]
        public void TestStudentSetIDnumber()
        {
            string name = "Biliana Georgieva";
            int idNumber = 1;
            Student student = new Student(name, idNumber);
            student.NumberID = 34;
            Assert.AreEqual(student.NumberID, 34);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentSetIDnumberNegative()
        {
            Student student = new Student("Biliana", 2344);
            student.NumberID = -34;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentSetIDnumberBigger()
        {
            Student student = new Student("Biliana", 2344);
            student.NumberID = 200000;
        }

        [TestMethod]
        public void TestStudentGetName()
        {
            string name = "Biliana Georgieva";
            int idNumber = 1;
            Student student = new Student(name, idNumber);
            string studentName = student.Name;
            Assert.AreEqual(studentName, "Biliana Georgieva");
        }
        [TestMethod]
        public void TestStudentGetNumberID()
        {
            string name = "Biliana Georgieva";
            int idNumber = 1;
            Student student = new Student(name, idNumber);
            int studentNumberID = student.NumberID;
            Assert.AreEqual(studentNumberID, 1);
        }

        [TestMethod]
        public void TestStudentToStringNumber()
        {
            string name = "Biliana Georgieva";
            int idNumber = 1;
            Student student = new Student(name, idNumber);
            Assert.AreEqual(student.ToString(), "NumberID: 1, Name: Biliana Georgieva");
        }
        
    }
}