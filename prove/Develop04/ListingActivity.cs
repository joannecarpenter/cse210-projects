using System;

class ListingActivity : Activity
{
    // Attributes
        // all attributes are inherited from the base Activity class
    // Constructors
    public ListingActivity() : base()
    {
        _activityType = "Listing Activity";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>
        {
            "When have you felt the Holy Ghost this month?",
            "What aspects of your city or neighborhood are you grateful for?",
            "What have others done in your life that you are grateful for?",
            "What happened today/yesterday/this week/this month/this year that you are grateful for?",
            "What relationships are you grateful for?",
            "What made you laugh or smile this week?"
        };
        _randomPrompt = "";        
    }
    // Methods
    public void RunListingActivity()
    {
        DisplayWelcome();
        Console.Clear();
        
        Console.WriteLine("Get ready...");
        // run the spinner while the activity "loads"
        PauseAndSpin();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayPrompt();
        Console.Write("You may begin in:");
        // counts down from 5
        PauseAndCountDown(5);
        Console.WriteLine();

        // Get start time
        DateTime startTime = DateTime.Now;
        // Add number of _seconds requested for activity to start time
        DateTime endTime = startTime.AddSeconds(_seconds);
        
        int loopCount = 0;
        do
        {    
            Console.Write(">");
            string userInput1 = Console.ReadLine();
            // count each prompt given with user response by counting each time this loops
            loopCount += 1;
   
            // prompts for user input will continue until the number of _seconds requested has been reached
        } while  (endTime > DateTime.Now);
        
        Console.WriteLine($"You have listed {loopCount} items!");
        DisplayEnd();   
    }
}