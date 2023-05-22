using System;

public abstract class GoalGenerator
{
    // Attributes
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    public List<string> _goals = new List<string>();

    // Constructors
    public GoalGenerator()
    {
        _goalName = "";
        _goalDescription = "";
        _goalPoints = 0;
    }

    // Methods
    public void SetGoalName(string goalName)
    {
        _goalName = goalName;   
    }
    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;   
    }
    public void SetGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;   
    }
    public virtual string DisplayGoal()
    {
        // Used to format the goal as it should be written in the _goals list 
        return "";
    }
    public virtual string DisplayCompletedGoal()
    {
        // Used to format the goal as it should be written in the _goals list after it has been completed
        return "";
    }
    public void DisplayGoalsList()
    {
        int goalNumber = 1;
        foreach (string line in _goals)
        {
            Console.WriteLine($"{goalNumber}. {line}");
            goalNumber += 1;
        }
    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual void RecordEvent()
    {}
}

// Methods

//    public string GetGoalAsCSV()
//         {
//             // Gets the entry object and returns it as a CSV record
//                 // Returns a string in a format that can then be inserted
//                 // into a list and ultimately into a CSV file
//             return string.Format("{0}|{1}|{2}", _goalName, _goalDescription, _goalPoints);
//         }  

//     public void LoadFromCSV()
//     {
//         // // Prompt the user for the csv file name to load
//         // Console.Write("Please enter the name of the goal file you would like to load: ");
//         // string fileName = Console.ReadLine();

//         // // Read the entire file into an array of strings
//         // string[] lines = System.IO.File.ReadAllLines(fileName);

//         // // Iterate through each string (goal) in the array
//         // foreach (string line in lines)
//         // {
//         //     // Split the string at the vertical pipe (|) and indexing each piece
//         //     string[] parts = line.Split("|");
//         //     string _goalName = parts[0];
//         //     string _goalDescription = parts[1];
//         //     string _goalPoints = parts[2];
//         //     string _completed = parts[3];
//         //     string _bonusPoints = parts[4];
//         //     // GoalType:GoalName,GoalDescription,GoalPointValue,CompleteBoolean,BonusPoints, 

//         //     // Format pieces of each goal 
//         //     Simple goal = new Simple(parts[0], parts[1], parts[2], parts[3]);
//         //     // Add formatted entry pieces back into the _goals list
//         //     _goals.Add(goal);
//         // }
//     }

//     public void SaveToCSV()
//     {

//     }