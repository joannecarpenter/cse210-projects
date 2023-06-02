using System;
using System.Collections.Generic;

public class ChecklistGoal : Goal
{
    // Attributes
    private int _bonusPoints = 0;
    private int _bonusRequirement = 0;
    private int _completedCount = 0;

    // Constructor
    public ChecklistGoal(string goalName, string goalDescription, int goalPoints, int bonusPoints, int bonusRequirement, int completedCount) : base(goalName, goalDescription, goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _bonusPoints = bonusPoints;
        _bonusRequirement = bonusRequirement;
        _completedCount = completedCount;
        _goalType = typeof(ChecklistGoal);
    }

    // Methods 
    public override void CreateGoal()
    {
        // Receive the goal information (_goalName, _goalDescription, _goalPoints)
        ReceiveGoalInformation();
        // Goals specific information
        ReceiveBonusPoints();
        ReceiveBonusRequirement();
    }

    public override string DisplayGoal()
    {
        // Checklist goals only get an X for completion once the bonus requirement has been met
        if (_completedCount >= _bonusRequirement)
        {
            return $"[X] {_goalName} ({_goalDescription}) -- Currently completed: {_completedCount}/{_bonusRequirement}";
        }
        else
        {
            return $"[ ] {_goalName} ({_goalDescription}) -- Currently completed: {_completedCount}/{_bonusRequirement}";
        }
    }
    public override int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public override int GetBonusRequirement()
    {
        return _bonusRequirement;
    }
    public override int GetCompletedCount()
    {
        return _completedCount;
    }
    public void ReceiveBonusPoints()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = Int32.Parse(Console.ReadLine());
    }
    public void ReceiveBonusRequirement()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _bonusRequirement = Int32.Parse(Console.ReadLine());
    }
    public void AddToCompletedCount()
    {
        _completedCount += 1;
    }
    public override string GetStringRepresentation()
    {
        return $"{_goalType}:{_goalName},{_goalDescription},{_goalPoints},{_bonusPoints},{_bonusRequirement},{_completedCount}";
    }
}