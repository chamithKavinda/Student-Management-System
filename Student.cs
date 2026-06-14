using System;

namespace Excersice01_StudentManagementSystem
{
    public class Student
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Invalid age.");
                }
            }
        }

        public string StudentID { get; }

        public Student(string name, int age, string studentID)
        {
            Name = name;
            Age = age;
            StudentID = studentID;
        }

        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Student ID: {StudentID}");
        }

        public virtual void GetDetails()
        {
            Console.WriteLine("General Student");
        }
    }
}