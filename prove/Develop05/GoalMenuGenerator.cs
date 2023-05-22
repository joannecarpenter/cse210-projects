using System;

public class GoalMenuGenerator
{
    // Attributes
    private string _goalChoice;
    private SimpleGoalGenerator _simpleGoal;
    private EternalGoalGenerator _eternalGoal;
    private ChecklistGoalGenerator _checklistGoal;

    // Constructors
    public GoalMenuGenerator(SimpleGoalGenerator simpleGoal, EternalGoalGenerator eternalGoal, ChecklistGoalGenerator checklistGoal)
    {
        _simpleGoal = simpleGoal;
        _eternalGoal = eternalGoal;
        _checklistGoal = checklistGoal;
    }

    // Methods
    public void CreateGoal()
    {
        DisplayGoalsMenu();
        ReceiveGoalChoice();
        ProcessGoalChoice();
    }

    public void DisplayGoalsMenu()
    {
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
    }

    public void ReceiveGoalChoice()
    {
        // Collect user input for goal choice
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
        _goalChoice = Console.ReadLine();
        Console.WriteLine();
    }

    // Collect user input for goal name, description, and points
    // All Goals have these questions in common
    public string ReceiveGoalName()
    {
        Console.Write("What is the name of your goal? ");
        return Console.ReadLine();
    }
    public string ReceiveGoalDescription()
    {
        Console.Write("What is a short description of it? ");
        return Console.ReadLine();
    }
    public int ReceiveGoalPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        return Int32.Parse(Console.ReadLine());
    }

    public void ProcessGoalChoice()
    {
        // Respond according to user input
        if (_goalChoice == "1"){
            Console.WriteLine("You have chosen to create a Simple Goal.");  // <--used for debugging
            _simpleGoal.SetGoalName(ReceiveGoalName());
            _simpleGoal.SetGoalDescription(ReceiveGoalDescription());
            _simpleGoal.SetGoalPoints(ReceiveGoalPoints());
            // Add call to process to create a simple goal, which includes simple goal specific functionality
            _simpleGoal.CreateSimpleGoal();   
        }
        else if (_goalChoice == "2"){
            Console.WriteLine("You have chosen to create an Eternal Goal.");   // <--used for debugging
            _eternalGoal.SetGoalName(ReceiveGoalName());
            _eternalGoal.SetGoalDescription(ReceiveGoalDescription());
            _eternalGoal.SetGoalPoints(ReceiveGoalPoints());
            // Add call to process to create an eternal goal, which includes simple goal specific functionality
            _eternalGoal.CreateEternalGoal();
        }
        else if (_goalChoice == "3"){
            Console.WriteLine("You have chosen to create a Checklist Goal.");   // <--used for debugging
            _checklistGoal.SetGoalName(ReceiveGoalName());
            _checklistGoal.SetGoalDescription(ReceiveGoalDescription());
            _checklistGoal.SetGoalPoints(ReceiveGoalPoints());
            // Add call to process to create a checklist goal
            _checklistGoal.CreateChecklistGoal();
        }
    }

}