using System;

class BreathingActivity : Activity
{
    // Attributes
       // all attributes are inherited from the base Activity class   
    // Constructors
    public BreathingActivity() : base()
    {
        _activityType = "Breathing Activity";
        _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                
    }
    // Methods
    public void RunBreathingActivity()
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
            Console.Write("Breathe in..."); 
            // counts down from 6
            PauseAndCountDown(6);
            Console.WriteLine();
            Console.Write("Now breathe out..."); 
            // counts down from 8
            PauseAndCountDown(8);
            Console.WriteLine();
            // repeat the breathing exercise lines until the number of _seconds passes
        } while  (endTime > DateTime.Now);

        DisplayEnd();
        
    }
}