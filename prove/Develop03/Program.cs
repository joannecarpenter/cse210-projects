using System;

class Program
{
    static void Main(string[] args)
    {
        // Other alternate scripture with only one verse
        // Reference _scriptureReference = new Reference("Hebrews", "11", "1");
        // Scripture scripture = new Scripture(_scriptureReference, "Now faith is the substance "+
        // "of things hoped for, the evidence of things not seen.");

        Reference _scriptureReference = new Reference("Proverbs", "3", "5", "6");
        Scripture scripture = new Scripture(_scriptureReference, "Trust in the Lord with all thine heart;"+
        " and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
    
        string userChoice = "";

        while (userChoice != "quit" && scripture.HasWordsLeft() == true)
        {
            // This will clear the console
            Console.Clear();
            // This will start by displaying the scripture 
            // and waiting for the user to press the enter key
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userChoice = Console.ReadLine();
            scripture.RemoveWords();  
        }
        Console.WriteLine("Nice work memorizing that scripture!");
    }

}