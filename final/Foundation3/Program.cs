using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        // Create a Lecture Event and Marketing Messages
        var address1 = new Address("100 Programming Way", "Rexburg", "Idaho", "83440");
        var lecture = new Lecture("Programming with Classes: Final Project", "A discussion of requirements for the final course project", "May 30, 2023", "3pm MST", "Marty McFly", 25, address1);
        
        Console.WriteLine("Lecture Standard Details:");
        lecture.GenerateStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Lecture Full Details:");
        lecture.GenerateFullDetails();
        Console.WriteLine();
        Console.WriteLine("Lecture Short Description:");
        lecture.GenerateShortDescription("Lecture");
        Console.WriteLine();
        Console.WriteLine();

        // Create a Reception Event and Marketing Messages
        var address2 = new Address("322 Conference Center Parkway", "Ocean City", "Maryland", "21842");
        var reception = new Reception("Wedding Reception for Bob and Jane", "Celebrating a new marriage", "April 3, 2023", "2pm EST", address2, "BobAndJane@yahoo.com");
        
        Console.WriteLine("Reception Standard Details:");
        reception.GenerateStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Reception Full Details:");
        reception.GenerateFullDetails();
        Console.WriteLine();
        Console.WriteLine("Reception Short Description:");
        reception.GenerateShortDescription("Reception");
        Console.WriteLine();
        Console.WriteLine();

        // Create an OutdoorGathering Event and Marketing Messages
        var address3 = new Address("530 Mariner's Way", "Virginia Beach", "Virginia", "23450");
        var outdoorGathering = new OutdoorGathering("10K Run for Autism Awareness", "Fundraising event for local autism chapter", "June 29, 2023", "10am ET", "sunny", address3);
        
        Console.WriteLine("Outdoor Gathering Standard Details:");
        outdoorGathering.GenerateStandardDetails();
        Console.WriteLine();
        Console.WriteLine("Outdoor Gathering Full Details:");
        outdoorGathering.GenerateFullDetails();
        Console.WriteLine();
        Console.WriteLine("Outdoor Gathering Short Description:");
        outdoorGathering.GenerateShortDescription("Outdoor Gathering");
        Console.WriteLine();
        Console.WriteLine();
    }
}