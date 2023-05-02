using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create menu and user input variables
        
        Journal journal = new Journal();

         List<string> menu = new List<string>()
        {
            "Please select an option by number:",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit"   
        };

        // create variable userSelection for option chosen from list
        string userSelection = "";
        // pull random prompt and save it to variable userPrompt
       
        
        do
        {
            foreach(string option in menu)
            {
                Console.WriteLine(option);
            }
            Console.Write("What would you like to do? ");
            userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                // Give user an input space to record journal entry
                //Console.Write("Response: ");
                //string userResponse = Console.ReadLine();
                
                journal.CreateJournalEntry();    //<---These entries are all instances of the Entry class.            
            } 

            else if (userSelection == "2")
            {
                // Display the journal entries
                journal.DisplayJournalEntries();
            } 

            else if (userSelection == "3")
            {
                // Load a journal file
                journal.LoadFromCSV();
            }

            else if (userSelection == "4")
            {
                // Save a journal file
                journal.SaveToCSV();
            } 

        } while (userSelection != "5");
        

    }
}