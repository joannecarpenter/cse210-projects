using System;

public abstract class Goal
{
    // Attributes
    protected string _goalName = "";
    protected string _goalDescription = "";
    protected int _goalPoints = 0;
    protected Type _goalType;


    // Constructor
    public Goal(string goalName, string goalDescription, int goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }

    // Methods
    public virtual void CreateGoal()
    {
        // Ask goal specific questions to create the goal
        // Format the goal as it should be saved in the _goals list
    }
    public virtual string DisplayGoal()
    {
        // Used to format the goal as it should be written in the _goals list 
        return "";
    }
    public virtual string GetStringRepresentation()
    {
        return "";
    }
    public virtual void IsComplete()
    { }
    public virtual void IsNotComplete()
    { }
    public virtual int GetBonusPoints()
    {
        return 0;
    }
    public virtual int GetBonusRequirement()
    {
        return 0;
    }
    public virtual int GetCompletedCount()
    {
        return 0;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    public int GetGoalPoints()
    {
        return _goalPoints;
    }

    public void ReceiveGoalInformation()
    {
        // Collect user input for goal name, description, and points
        // All Goals have these questions in common
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = Int32.Parse(Console.ReadLine());
    }
}