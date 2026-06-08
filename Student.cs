using System;

namespace Excersice01_StudentManagementSystem
{
    public class Student
    {
        // Private fields (encapsulation)
        private string name;
        private int age;

        // Public property (Name)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Public property (Age with validation)
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Invalid age. Must be between 0 and 120.");
                }
            }
        }

        // Read-only property (StudentID)
        public string StudentID { get; }

        // Constructor (required for StudentID initialization)
        public Student(string name, int age, string studentID)
        {
            Name = name;
            Age = age;
            StudentID = studentID;
        }

        // Display basic info
        public void DisplayBasicInfo()
        {
            Console.WriteLine("----- Student Basic Info -----");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Student ID: {StudentID}");
        }

        // Get full details
        public void GetDetails()
        {
            Console.WriteLine("----- Student Details -----");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Student ID: {StudentID}");
        }
    }
}