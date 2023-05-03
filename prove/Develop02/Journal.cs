using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    // Attributes
    // List<string> _entries; <---My original version where the list was of strings instead of the data type Entry
    //UPDATE: He changed this in the video from string to Entry, which is our custom class
    List<Entry> _entries; 
    

    // Constructor
    public Journal()
    {
       // initializes the list in constructor
        _entries = new List<Entry>(); 
    }

    // Methods
    public void DisplayJournalEntries()
    {
        //foreach (string entry in _entries) <---My original version here where the _entries list was strings
        foreach (Entry entry in _entries) 
        //<---UPDATE: The list of entries is of the data type Entry, not date type string
        //Each entry is of the data type (or class) Entry,
        //and contained within each Entry is a string of date, prompt, response (as is dictated in the Entry class)
        {
            //Console.WriteLine(_entries); <---My original version
            //UPDATED
            entry.DisplayEntry();
        }
    }

    public void CreateJournalEntry()
    {
        PromptGenerator prompt = new PromptGenerator();
        string userPrompt = prompt.GetRandomPrompt();

        // Get current date
        DateTime _date = DateTime.Now;
        string dateText = _date.ToShortDateString();

        Console.WriteLine(userPrompt);
        
        // Give user an input space to record journal entry
        Console.Write("Response: ");
        string userResponse = Console.ReadLine();
        
        Entry _entry = new Entry(dateText, userPrompt, userResponse);
        //_entries.Add(userResponse);
        _entries.Add(_entry);
    }

    public void SaveToCSV()
    {
        // Create a new list to hold all csv formated entries of the Journal
        List<string> lines = new List<string>();
        // Format each entry into csv format as done in GetEntryAsCSV
        foreach (Entry _entry in _entries)
            {
                lines.Add(_entry.GetEntryAsCSV());
            }
        
        // Prompt user for file name to save to new csv file
        Console.Write("Please enter a new file name for saving: ");
        string fileName = Console.ReadLine();
        
        // Create the new file named fileName, writes the list lines to that file, then closes the file.
        File.WriteAllLines(fileName, lines);
    }

    public void LoadFromCSV()
    {
        // Prompt the user for the csv file name to load
        Console.Write("Please enter the name of the file you would like to load: ");
        string fileName = Console.ReadLine();

        // Read the entire file into an array of strings
        string[] lines = System.IO.File.ReadAllLines(fileName);

        // Iterate through each string (AKA journal entry) in the array
        foreach (string line in lines)
        {
            // Split the string at the vertical pipe (|) and indexing each piece
            string[] parts = line.Split("|");
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            // Format pieces of each entry 
            Entry entry = new Entry(parts[0], parts[1], parts[2]);
            // Add formatted entry pieces back into the _entries list
            _entries.Add(entry);
        }
    }
}