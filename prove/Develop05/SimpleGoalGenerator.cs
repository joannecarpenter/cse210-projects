using System;
using System.Collections.Generic;

public class SimpleGoalGenerator : GoalGenerator
{
    // Attributes
    private bool _isComplete;

    // Constructors
  

    // Methods
    public void CreateSimpleGoal()
    {
        // Add the formatted simple goal to the _goals list
        _goals.Add(DisplayGoal());        
    }
    
    public override string DisplayGoal()
    {
        return $"[ ] {_goalName} ({_goalDescription})";
    }
    public override string DisplayCompletedGoal()
    {
        return $"[X] {_goalName} ({_goalDescription})";
    }
    public override bool IsComplete()
    {
        // If the goal selected (by number) in RecordEvent is a simple goal (GoalType = simple)
        // add the goal's goalPoints int value to the total points (_totalPoints)

        return true;
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
    // Constructors

    //   public Simple(string _goalName, string _goalDescription, int _goalPoints, bool isComplete) : base (_goalName, _goalDescription, _goalPoints)
    // {
    //     _isComplete = isComplete;
    // }
//     // public Simple(string goalName, string goalDescription)
//     // {
//     //     goalName = _goalName;
//     //     goalDescription = _goalDescription;
//     // }
