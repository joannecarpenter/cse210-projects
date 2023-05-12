using System;

class ReflectingActivity : Activity
{
    // Attributes
       // all attributes are inherited from the base Activity class
    // Constructors
    public ReflectingActivity() : base()
    {
        _activityType = "Reflecting Activity";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string>
        {
            "Think of a time when you did something really difficult.",
            "Think of a time when you did something that required great physical exertion.",
            "Think of a time when you set aside your own needs to help someone else.",
            "Think of a time when you were faced with a major trial.",
            "Think of a time when you wanted to give up, but perserved anyway.",
        };
        _randomPrompt = "";        
    }
    // Methods
    public void RunReflectionActivity()
    {
        DisplayWelcome();
        Console.Clear();
        
        Console.WriteLine("Get ready...");
        // run the spinner while the activity "loads"
        PauseAndSpin();
        // Get start time
        DateTime startTime = DateTime.Now;
        // Add number of _seconds requested for activity to start time
        DateTime endTime = startTime.AddSeconds(_seconds);
        do
        {
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt:");
            DisplayPrompt();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience."); 
            Console.WriteLine();
            Console.Write("You may begin in:");
            // counts down from 5
            PauseAndCountDown(5);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("> How did you feel when it was complete?");
            // run the pause and spinner at the end of the line
            PauseAndSpin();
            Console.WriteLine();
            Console.Write("> What is your favorite thing about this experience?");
            // run the pause and spinner at the end of the line
            PauseAndSpin();
            // repeat all lines from get ready to userInput2 until the number of _seconds passes
        } while  (endTime > DateTime.Now);

        DisplayEnd();       
    }
}