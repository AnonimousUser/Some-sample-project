using System;

namespace SchoolGroup
{
    public class Student
    {
        private string name;

        private int numberID;

        public Student(string name, int numberID)
        {
            if ((name.Length == 1) || (name == string.Empty))
            {
                throw new ArgumentException("Student must have name with more than one letter!");
            }
            if (name == null) 
            {
                throw new NullReferenceException("Student name can not be null!");
            }

            this.name = name;

            if (numberID < 0 || numberID > 99999)
            {
                throw new ArgumentOutOfRangeException("the numberID of the student must be in interval[0...99999]");
            }

            this.numberID = numberID;
        }

        public override string ToString()
        {
            return string.Format("NumberID: {0}, Name: {1}", numberID, name);
        }

        public int NumberID
        {
            get
            {
                return this.numberID;
            }

            set
            {
                if (value < 0 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("the numberID of the student must be in ArgumentOutOfRangeException[0...99999]");
                }

                this.numberID = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if ((value.Length == 1) || (value == ""))
                {
                    throw new ArgumentException("Student must have name with more than one letter!");
                }
                if (value == null)
                {
                    throw new NullReferenceException("Student name can not be null!");
                }

                this.name = value;
            }
        }
    }
}