using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Noah", "Art");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);
        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("Jacob", "Math", "Order of Operations", "1-10");
        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine(homeworkList);
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Gavin", "English", "The best day ever!");
        string writingInformation = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingInformation);
    }
}