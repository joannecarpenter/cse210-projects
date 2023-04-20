using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int gradeNumber = int.Parse(userInput);
        
        // Determining the letter grade based on the number grade.
        string letter = "";

        if (gradeNumber >= 90)
        {
            letter = "A";
            // string letterGrade = "A";
            // Console.WriteLine($"The letter grade is {letterGrade}.");
        }

        else if (gradeNumber >= 80)
        {
            letter = "B";
            // string letterGrade = "B";
            // Console.WriteLine($"The letter grade is {letterGrade}.");
        }

        else if (gradeNumber >= 70)
        {
            letter = "C";
            // string letterGrade = "C";
            // Console.WriteLine($"The letter grade is {letterGrade}.");
        }

        else if (gradeNumber >= 60)
        {
            letter = "D";
            // string letterGrade = "D";
            // Console.WriteLine($"The letter grade is {letterGrade}.");
        }

        else if (gradeNumber < 60)
        {
            letter = "F";
            // string letterGrade = "F";
            // Console.WriteLine($"The letter grade is {letterGrade}.");
        }


        // Printing the letter grade.
        Console.WriteLine($"The letter grade is {letter}.");

        // Determining pass or fail and printing appropriate remarks.
        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }

        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course this time. Please re-enroll.");
        }
    }
}