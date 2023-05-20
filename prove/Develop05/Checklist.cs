using System;
using System.Collections.Generic;

public class Checklist : Goal
{
    // Attributes 
    private string _bonusReq;
    private string _bonusPoints;
    // Constructors
    public Checklist()
    {

    }

    // Methods 
    public void CreateChecklistGoal()
    {
        // Create a new instance of the Goal() class to format the goal
        Goal checklistGoal = new Goal(_goalName, _goalDescription, _goalPoints);
        // Add the new checklist goal to the list of goals
        _goals.Add(checklistGoal);
    }
}