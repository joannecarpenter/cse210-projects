using System;
using System.Collections.Generic;

public class ChecklistGoalGenerator : GoalGenerator
{
    // Attributes
    private int _bonusPoints; 
    private int _bonusRequirement;
    
    
    // Constructors
    public ChecklistGoalGenerator()
    {
        _bonusPoints = 0;
        _bonusRequirement = 0;

    }
    
    // Methods 
    public void CreateChecklistGoal()
    {
        // Goal specific questions
        SetBonusPoints(ReceiveBonusPoints());
        SetBonusRequirement(ReceiveBonusRequirement());
        // Add the formatted checklist goal to the _goals list
        _goals.Add(DisplayGoal());        
    }
    
    public override string DisplayGoal()
    {
        return $"[ ] {_goalName} ({_goalDescription}) -- Currently completed: 0/3";
    }
    public override string DisplayCompletedGoal()
    {
        // Checklist goals only get an X for completion once the bonus requirement has been met
        return $"[X] {_goalName} ({_goalDescription})";
    }
    public int ReceiveBonusPoints()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        return Int32.Parse(Console.ReadLine());
    }
    public int ReceiveBonusRequirement()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        return Int32.Parse(Console.ReadLine());
    }
    public void SetBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;   
    }
    public void SetBonusRequirement(int bonusRequirement)
    {
        _bonusRequirement = bonusRequirement;   
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
            // find the bonusPoints for that specific goal
            // add that number of bonus points to the totalPoints
        Console.WriteLine("Congratulations! You have earned {_goalPoints} points!"); //<--Add the $ after you get the goalPoints variable straight
        Console.WriteLine("You now have {_totalPoints} points."); //<--Add the $ after you get the totalPoints variable straight
    }
}