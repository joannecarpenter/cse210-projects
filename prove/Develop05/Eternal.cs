using System;
using System.Collections.Generic;

public class Eternal : Goal
{
    // Attributes 

    // Constructors
    public Eternal()
    {

    }

    // Methods 
    public void CreateEternalGoal()
    {
        // Create a new instance of the Goal() class to format the goal
        Goal eternalGoal = new Goal(_goalName, _goalDescription, _goalPoints);
        // Add the new eternal goal to the list of goals
        _goals.Add(eternalGoal);        
    }
}