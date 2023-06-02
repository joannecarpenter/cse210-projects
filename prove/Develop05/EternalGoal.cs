using System;
using System.Collections.Generic;

public class EternalGoal : Goal
{
    // Attributes

    // Constructor
    public EternalGoal(string goalName, string goalDescription, int goalPoints) : base(goalName, goalDescription, goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _goalType = typeof(EternalGoal);
    }
    // Methods
    public override void CreateGoal()
    {
        // Receive the goal information (_goalName, _goalDescription, _goalPoints)
        ReceiveGoalInformation();
    }
    public override string DisplayGoal()
    {
        // Eternal goals are never officially completed,so it remains the same for both
        return $"[ ] {_goalName} ({_goalDescription})";
    }
    public override string GetStringRepresentation()
    {
        return $"{_goalType}:{_goalName},{_goalDescription},{_goalPoints}";
    }
}