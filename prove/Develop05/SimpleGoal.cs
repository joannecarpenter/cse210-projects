using System;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
    // Attributes
    private bool _isComplete = false;

    // Constructor
    public SimpleGoal(string goalName, string goalDescription, int goalPoints, bool isComplete) : base(goalName, goalDescription, goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _isComplete = isComplete;
        _goalType = typeof(SimpleGoal);
    }

    // Methods   
    public override void CreateGoal()
    {
        // Receive the goal information (_goalName, _goalDescription, _goalPoints)
        ReceiveGoalInformation();
    }
    public override string DisplayGoal()
    {
        if (_isComplete)
        {
            return $"[X] {_goalName} ({_goalDescription})";
        }
        else
        {
            return $"[ ] {_goalName} ({_goalDescription})";
        }
    }
    public override void IsComplete()
    {
        _isComplete = true;
    }
    public override string GetStringRepresentation()
    {
        return $"{_goalType}:{_goalName},{_goalDescription},{_goalPoints},{_isComplete}";
    }

}