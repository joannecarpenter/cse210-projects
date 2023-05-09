using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string assignment1 = assignment.GetSummary();
        Console.WriteLine(assignment1);

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string mathAssignment1 = mathAssignment.GetSummary();
        string mathAssignment2 = mathAssignment.GetHomeworkList();
        Console.WriteLine(mathAssignment1);
        Console.WriteLine(mathAssignment2);

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string writingAssignment1 = writingAssignment.GetSummary();
        string writingAssignment2 = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingAssignment1);
        Console.WriteLine(writingAssignment2);
    }
}

// NOTED FROM SAMPLE SOLUTION:
// Code can be made more concise by combining two lines into one (i.e. lies 8 and 9) as follows
// Console.WriteLine(assignment.GetSummary());