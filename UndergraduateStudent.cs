using System;

namespace Excersice01_StudentManagementSystem
{
    public class UndergraduateStudent : Student
    {
        public string Major { get; set; }

        public int Year { get; set; }

        public UndergraduateStudent(
            string name,
            int age,
            string studentID,
            string major,
            int year)
            : base(name, age, studentID)
        {
            Major = major;
            Year = year;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Major: {Major}");
            Console.WriteLine($"Year: {Year}");
        }
    }
}