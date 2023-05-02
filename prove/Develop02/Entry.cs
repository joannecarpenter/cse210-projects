using System;
using System.Collections.Generic;

public class Entry
{
    // Attributes
    string date, prompt, response;

    // Constructor
    public Entry (string _date, string _prompt, string _response)
    {
        date = _date;
        prompt = _prompt;
        response = _response;
    }
    // Methods
    public void DisplayEntry()
    {
        // Formats the 3 attributes and then prints a line with them on it.
        Console.WriteLine($"Date: {date} - Prompt: {prompt}");
        Console.WriteLine(response);
    }

    public string GetEntryAsCSV()
    {
        // Gets the entry object and returns it as a CSV record
            // Returns a string in a format that can then be inserted
            // into a list and ultimately into a CSV file
        return string.Format("{0}|{1}|{2}", date, prompt, response);
    }
}