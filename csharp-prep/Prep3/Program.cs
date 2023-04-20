using System;

class Program
{
    static void Main(string[] args)
    {
        // Random number is generated for the magic number.
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        
        // User enters the magic number.
        // Console.Write("What is the magic number? ");
        // string userNumber = Console.ReadLine();
        // int number = int.Parse(userNumber);
        
        int guess = 9999;
        int count = 0;
        
        while (guess != number)
        {
             // User tries to guess the magic number.
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
            count += 1;

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }

        }

        if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It only took you {count} guesses!");
            }
    }
}