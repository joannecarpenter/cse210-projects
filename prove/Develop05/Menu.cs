using System;

public class Menu : Goal
{
    // Attributes


    // Constructors


    // Methods

    public void CreateGoal()
    {
        // Display goals menu
        Console.WriteLine();
        List<string> goalMenu = new List<string>()
        {
            "The types of Goals are:",
            "1.	Simple Goal",
            "2.	Eternal Goal",
            "3.	Checklist Goal"
        };
        foreach (string item in goalMenu){
        Console.WriteLine($"{item}");
        };
        // Collect user input for goal choice
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
        string goalChoice = Console.ReadLine();
        Console.WriteLine();

        // Collect user input - All Goals have these questions in common
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = Int32.Parse(Console.ReadLine());


        // Respond according to user input
        if (goalChoice == "1"){
            // Console.WriteLine("You have chosen to create a Simple Goal.");  // <--used for debugging
            // Add call to process to create a simple goal
            Simple goal = new Simple();
            goal.CreateSimpleGoal();
            
        }
        else if (goalChoice == "2"){
            // Console.WriteLine("You have chosen to create an Eternal Goal.");   // <--used for debugging
            // Add call to process to create an eternal goal
            Eternal goal = new Eternal();
            goal.CreateEternalGoal();
        }
        else if (goalChoice == "3"){
            // Console.WriteLine("You have chosen to create a Checklist Goal.");   // <--used for debugging
            // Add call to process to create a checklist goal
            Checklist goal = new Checklist();
            goal.CreateChecklistGoal();
        }
    }
}