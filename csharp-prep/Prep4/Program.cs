using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the list.
        List<int> userNumbers = new List<int>();
        
        // Give user instructions.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // Define value of number prior to looping due to its relevance to the loop's continuance.
        int number = 1;
        
        // While user enters any number except 0, add it to the list.
        while (number != 0)
        {
            // Request user input a number.
            Console.Write("Enter number: ");
            // Convert user entered string into an integer.
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            // Add integer to the list.
            userNumbers.Add(number);
        }
        
        // Print list for debugging purposes.    
        // foreach (int entry in userNumbers)
        // {
        //     Console.WriteLine(entry);
        // }

        // Remove the 0 that was added to the end of the list.
        userNumbers.RemoveAt(userNumbers.Count - 1);

        // Compute the sum of the numbers in the list.
        int sum = userNumbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average of the numbers in the list.
        double average = userNumbers.Average();
        Console.WriteLine($"The average is: {average}");

        // Find the largest number in the list.
        int max = userNumbers.Max();
        Console.WriteLine($"The largest number is: {max}");
    }
}