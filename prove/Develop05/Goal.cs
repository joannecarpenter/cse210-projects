using System;
using System.Collections.Generic;
using System.IO;

public class Goal
{
    // Attributes
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    protected List<Goal> _goals;
    protected string _newGoal;
    protected string _completed;

    // Constructors
    public Goal(string goalName, string goalDescription, int goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;

    }
    public Goal()
    {
        _goals = new List<Goal>()
        {
            
        };
    }

    // Methods
    public void DisplayGoal()
    {
        // Formats the 2 attributes and then prints a line with them on it.
        Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");    
    }
 

    public string GetGoalAsCSV()
        {
            // Gets the entry object and returns it as a CSV record
                // Returns a string in a format that can then be inserted
                // into a list and ultimately into a CSV file
            return string.Format("{0}|{1}|{2}", _goalName, _goalDescription, _goalPoints);
        }

    
    public void DisplayGoalsList()
    {
        foreach (Goal goal in _goals){
            DisplayGoal();
            string goalString = Console.ReadLine();
            Console.WriteLine($"{goalString}");
        }  

    }

    public void CalculatePoints(int goalPoints)
    {
        _goalPoints = goalPoints;
        // Add up all points to be displayed at various times
        // Be sure to parse here because the input goalPoints will be a string
        Console.WriteLine($"You have {_goalPoints} points.");
    }

    

    public void LoadFromCSV()
    {
        // // Prompt the user for the csv file name to load
        // Console.Write("Please enter the name of the goal file you would like to load: ");
        // string fileName = Console.ReadLine();

        // // Read the entire file into an array of strings
        // string[] lines = System.IO.File.ReadAllLines(fileName);

        // // Iterate through each string (goal) in the array
        // foreach (string line in lines)
        // {
        //     // Split the string at the vertical pipe (|) and indexing each piece
        //     string[] parts = line.Split("|");
        //     string _goalName = parts[0];
        //     string _goalDescription = parts[1];
        //     string _goalPoints = parts[2];
        //     string _completed = parts[3];
        //     string _bonusPoints = parts[4];
        //     // GoalType:GoalName,GoalDescription,GoalPointValue,CompleteBoolean,BonusPoints, 

        //     // Format pieces of each goal 
        //     Simple goal = new Simple(parts[0], parts[1], parts[2], parts[3]);
        //     // Add formatted entry pieces back into the _goals list
        //     _goals.Add(goal);
        // }
    }

    public void SaveToCSV()
    {

    }
}