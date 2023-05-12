using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> menu = new List<string>()
        {
            "Menu Options:",
            "1. Start breathing activity",
            "2. Start reflecting activity",
            "3. Start listing activity",
            "4. Quit"               
        };

        // create variable userSelection for option chosen from list
        string userSelection = "";
        // pull random prompt and save it to variable userPrompt
       
        Console.Clear();
        do
        {   
            Console.WriteLine();
            foreach(string option in menu)
            {
                Console.WriteLine(option);
            }
            Console.Write("Select a choice from the menu: ");
            userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                Console.Clear();
                BreathingActivity activity1 = new BreathingActivity();
                activity1.RunBreathingActivity();
                //Console.WriteLine("Run Breathing Activity");         
            } 

            else if (userSelection == "2")
            {
                Console.Clear();
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.RunReflectionActivity();
                //Console.WriteLine("Run Reflecting Activity");
            } 

            else if (userSelection == "3")
            {
                Console.Clear();
                ListingActivity activity3 = new ListingActivity();
                activity3.RunListingActivity();
                //Console.WriteLine("Run Listing Activity");
            }

            else if (userSelection == "4")
            {
                Console.Clear();
                Console.WriteLine("Thank you for participating in a mindfulness activity. Have a great day!");
            } 

        } while (userSelection != "4");    
    }
}