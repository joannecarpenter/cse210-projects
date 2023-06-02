using System;
using System.IO;

class AllGoals
{
    // Attributes
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;
    private int _goalNumber = 0;
    private int _goalIndex = 0;

    // Methods
    public void AddToGoalsList(Goal goal)
    {
        // Add goal to all goals list
        _goals.Add(goal);
    }

    public void DisplayGoalsList()
    {
        // Display all goals in goals list using the Display Goals format for each goal type
        foreach (Goal goal in _goals)
        {
            // Display the goal as required by the individual goal type's DisplayGoal method
            Console.WriteLine(goal.DisplayGoal());
        }
    }
    public void SaveToCSV()
    {
        Console.Write("What file name would you like to use to save your goals? ");
        string fileName = Console.ReadLine();
        // Create a new list to hold all csv formated entries of the Journal
        List<string> lines = new List<string>();
        // Iterate through the goal list and format each goal and add it to the new lines list
        foreach (Goal goal in _goals)
        {
            lines.Add(goal.GetStringRepresentation());
        }
        // Create the new file named fileName, write the list lines to that file, and then close the file.
        File.WriteAllLines(fileName, lines);
    }
    public void LoadFromCSV()
    {
        // Prompt the user for the csv file name to load
        Console.Write("Please enter the name of the goal file you would like to load: ");
        string fileName = Console.ReadLine();
        // Read the entire file into an array of strings named lines
        string[] lines = System.IO.File.ReadAllLines(fileName);
        // Iterate through each string (goal) in the array
        foreach (string line in lines)
        {
            // Split each string at the colon and comma
            string[] parts = line.Split(':', ',');

            string goalType = parts[0];
            switch (goalType)
            {
                // Simple Goal
                case "SimpleGoal":
                    // SimpleGoal:GoalName,GoalDescription,GoalPointValue,CompleteBoolean
                    SimpleGoal sGoal = new SimpleGoal(parts[1], parts[2], Int32.Parse(parts[3]), bool.Parse(parts[4]));
                    _goals.Add(sGoal);
                    break;
                // Eternal Goal
                case "EternalGoal":
                    // EternalGoal:GoalName,GoalDescription,GoalPointValue
                    EternalGoal eGoal = new EternalGoal(parts[1], parts[2], Int32.Parse(parts[3]));
                    _goals.Add(eGoal);
                    break;
                // Checklist Goal
                case "ChecklistGoal":
                    // ChecklistGoal:GoalName,GoalDescription,GoalPointValue,BonusPoints,BonusRequirement,CompletedCount
                    ChecklistGoal cGoal = new ChecklistGoal(parts[1], parts[2], Int32.Parse(parts[3]), Int32.Parse(parts[4]), Int32.Parse(parts[5]), Int32.Parse(parts[6]));
                    _goals.Add(cGoal);
                    break;
            }
        }
    }
    public void RecordEvent()
    {
        _goalNumber = 0;
        Console.WriteLine("The goals are:");
        // DisplayGoalListByName with a number before each goal
        foreach (Goal goal in _goals)
        {
            _goalNumber++;
            string goalName = goal.GetGoalName();
            Console.WriteLine($"{_goalNumber}. {goalName}");
        }

        Console.Write("Which goal did you accomplish? ");
        int eventChoice = Int32.Parse(Console.ReadLine());

        // This gives the index because index starts at 0, not 1 like our numbered list the user is choosing from.
        _goalIndex = eventChoice - 1;

        //For the goal chosen in event choice, get goal points and add them to the total
        Goal eventGoal = _goals[_goalIndex];
        int goalPoints = eventGoal.GetGoalPoints();
        Console.WriteLine($"Congratulations! You have earned {goalPoints} points!");

        string goalType = $"{eventGoal.GetType()}";

        switch (goalType)
        {
            case "SimpleGoal":
                // change isComplete to true
                eventGoal.IsComplete();
                // Add the goal points to the running total
                _totalPoints += goalPoints;
                Console.WriteLine($"You now have {_totalPoints} points.");
                break;

            case "EternalGoal":
                // Add the goal points to the running total
                _totalPoints += goalPoints;
                Console.WriteLine($"You now have {_totalPoints} points.");
                break;

            case "ChecklistGoal":
                // Add 1 to the completed count for that goal
                int completedCount = eventGoal.GetCompletedCount();
                completedCount += 1;
                // Decide if bonus requirement has been met
                int bonusRequirement = eventGoal.GetBonusRequirement();
                if (completedCount >= bonusRequirement)
                {
                    // Add bonus points to total points
                    int bonusPoints = eventGoal.GetBonusPoints();
                    _totalPoints += bonusPoints;
                }
                // Add the goal points to the running total
                _totalPoints += goalPoints;
                Console.WriteLine($"You now have {_totalPoints} points.");
                break;
        }
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
}