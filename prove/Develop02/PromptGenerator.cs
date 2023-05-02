using System;
using System.Collections.Generic;

class PromptGenerator
{
    // Attributes
    // Create list of prompts
    public List<string> _prompts;
    //public string randomPrompt;
    

    // Constructor with default/initial value
    // You know it is a constructor because it does not give a data type
    // like the other methods do.
    public PromptGenerator()
    {
      _prompts = new List<string>
        {
            "What was your favorite part of today?",
            "What have you learned today?",
            "If you could go anywhere tomorrow, where would you go, and why?",
            "Who was the most interesting person you interacted with today?",
            "If you had the ability to change anything about today, what would you change?",
            "What are you looking forward to tomorrow, and why?",
            "How would you describe your state of mind right now?",
            "What are you grateful for today - big or small?",
            "What is one thing that you love about yourself, and why?",
            "What goals did you work toward today?",
            "What did you do today to make someone else's load a little lighter?",
            "Who helped bring joy to your life today?"
        };
    }

    // Methods
    public string GetRandomPrompt()
    {
        
        // Create an Random object
        Random rand = new Random();
        // Generate a random index less than the size of the list
        int index = rand.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        // Display the result
        return randomPrompt;
    }
}

