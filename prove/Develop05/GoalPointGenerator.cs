class GoalPointGenerator
{
    // Attributes
    
    private int _totalPoints;

    // Constructors

    // Methods

    public int getTotalPoints()
    {
        return _totalPoints;
    }

    public void CalculateDisplayPoints()
    {
        Console.WriteLine($"You have {_totalPoints} points.");
    }
    
}

//     // public void CalculatePoints(int goalPoints)
//     // {
//     //     _goalPoints = goalPoints;
//     //     // Add up all points to be displayed at various times
//     //     // Be sure to parse here because the input goalPoints will be a string
//     //     Console.WriteLine($"You have {_goalPoints} points.");
//     // }