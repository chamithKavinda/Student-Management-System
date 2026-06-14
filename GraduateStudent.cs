using Excersice01_StudentManagementSystem;

public class GraduateStudent : Student
{
    public string ResearchTopic { get; set; }
    public string AdvisorName { get; set; }

    public GraduateStudent(
        string name,
        int age,
        string studentID,
        string researchTopic,
        string advisorName)
        : base(name, age, studentID)
    {
        ResearchTopic = researchTopic;
        AdvisorName = advisorName;
    }

    public override void GetDetails()
    {
        Console.WriteLine($"Research Topic: {ResearchTopic}");
        Console.WriteLine($"Advisor: {AdvisorName}");
    }
}