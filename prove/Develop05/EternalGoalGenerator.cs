using System;
using System.Collections.Generic;

public class EternalGoalGenerator : GoalGenerator
{
    // Attributes

    // Constructors

    // Methods
    public void CreateEternalGoal()
    {
        // Add the formatted eternal goal to the _goals list
        _goals.Add(DisplayGoal());        
    }
    
    public override string DisplayGoal()
    {
        return $"[ ] {_goalName} ({_goalDescription})";
    }
    public override string DisplayCompletedGoal()
    {
        // Eternal goals are never officially completed 
        return $"[ ] {_goalName} ({_goalDescription})";
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override void RecordEvent()
    {
         // From the goalAccomplished variable (number of goal that was accomplished):
            // find the goalPoints for that specific goal
            // add that number of goalPoints to the totalPoints
        Console.WriteLine("Congratulations! You have earned {_goalPoints} points!"); //<--Add the $ after you get the goalPoints variable straight
        Console.WriteLine("You now have {_totalPoints} points."); //<--Add the $ after you get the totalPoints variable straight
    }
}   

    // public void CreateEternalGoal(string _goalName, string _goalDescription, int _goalPoints, bool isComplete) : base (_goalName, _goalDescription, _goalPoints)
    // {
    //     // Create a new instance of the Goal() class to format the goal
    //     Goal eternalGoal = new Goal(_goalName, _goalDescription, _goalPoints);
    //     // Add the new eternal goal to the list of goals
    //     _goals.Add(eternalGoal);        
    // }
