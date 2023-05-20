using System;
using System.Collections.Generic;

public class Simple : Goal
{
    // Attributes 
    private bool _isComplete;
    // Constructors
    public Simple()
    {

    }
    public Simple(string _goalName, string _goalDescription, int _goalPoints, bool isComplete) : base (_goalName, _goalDescription, _goalPoints)
    {
        _isComplete = isComplete;
    }

    // Methods 
    public void CreateSimpleGoal()
    {
        // Create a new instance of the Goal() class to format the goal
        Goal simpleGoal = new Goal(_goalName, _goalDescription, _goalPoints);
        // Add the new simple goal to the list of goals
        _goals.Add(simpleGoal);        
    }
}