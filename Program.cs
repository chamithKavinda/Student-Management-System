namespace Excersice01_StudentManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        // Create Student object
        Student student = new Student("Test Student", 20, "S001");

        // Create UndergraduateStudent object
        UndergraduateStudent undergrad =
            new UndergraduateStudent(
                "Chamith Kavinda",
                25,
                "U001",
                "Computer Science",
                3);

        // Create GraduateStudent object
        GraduateStudent graduate =
            new GraduateStudent(
                "Chamith Kavinda",
                25,
                "G001",
                "Artificial Intelligence in Education",
                "Dr. Chamila");

        // Demonstrate modifying properties
        student.Age = 22;
        undergrad.Major = "Software Engineering";
        graduate.AdvisorName = "Dr. Sahan";

        Console.WriteLine("===== STUDENT =====");
        student.DisplayBasicInfo();
        student.GetDetails();

        Console.WriteLine("\n===== UNDERGRADUATE STUDENT =====");
        undergrad.DisplayBasicInfo();
        undergrad.GetDetails();

        Console.WriteLine("\n===== GRADUATE STUDENT =====");
        graduate.DisplayBasicInfo();
        graduate.GetDetails();

        Console.ReadLine();
    }
}

