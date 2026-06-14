namespace Excersice01_StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student =
                new Student("Test Student", 20, "S001");

            UndergraduateStudent undergrad =
                new UndergraduateStudent(
                    "Chamith Kavinda",
                    25,
                    "U001",
                    "Computer Science",
                    3);

            GraduateStudent graduate =
                new GraduateStudent(
                    "Chamith Kavinda",
                    25,
                    "G001",
                    "AI in Education",
                    "Dr. Chamila");

            //student.Age = 22;
            //undergrad.Major = "Software Engineering";
            //graduate.AdvisorName = "Dr. Sahan";

            Console.WriteLine("===== STUDENT =====");
            student.DisplayBasicInfo();
            student.GetDetails();

            Console.WriteLine("\n===== UNDERGRADUATE =====");
            undergrad.DisplayBasicInfo();
            undergrad.GetDetails();

            Console.WriteLine("\n===== GRADUATE =====");
            graduate.DisplayBasicInfo();
            graduate.GetDetails();

            Console.ReadLine();
        }
    }
}