using System;

public class Activity
{
    // Attributes
    protected string _activityType, _activityDescription;
    protected int _seconds;
    protected List<string> _prompts;
    protected string _randomPrompt;
    protected List<string> _animationStrings;
    // Constructors
    public Activity()
    {
        _activityType = "";
        _activityDescription = "";
        _seconds = 0; 
        _prompts = new List<string>{};
        _randomPrompt = "";
        _animationStrings = new List<string>{};
    }
    // Methods
    public void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the {_activityType}.");
        Console.WriteLine();
        Console.WriteLine($"{_activityDescription}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();
        _seconds = int.Parse(userInput);
    }
     public void PauseAndCountDown(int count)
    {
        for (int i = count; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }    
    }
     public void PauseAndSpin()
    {
        // Populate the _animationStrings list
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");
        
        // Loop through list to create spinner effect
        foreach (string s in _animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
     public void DisplayEnd()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        // spinner while it loads the next sentence
        PauseAndSpin();
        Console.WriteLine($"You have completed another {_seconds} seconds of the {_activityType}.");
        // spinner
        PauseAndSpin();
        Console.Clear();
    }
    public string GetPrompt()
    {
        // Create an Random object
        Random rand = new Random();
        // Generate a random index less than the size of the list
        int index = rand.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        // Display the result
        return randomPrompt;
    }
        public void DisplayPrompt()
    {
        _randomPrompt = GetPrompt();
        Console.WriteLine();
        Console.WriteLine($"--- {_randomPrompt} ---");
        Console.WriteLine();
    }
}