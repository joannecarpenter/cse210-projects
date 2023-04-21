using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string userName = PromptUserName();
        int number = PromptUserNumber();

        int numberSquared = SquareNumber(number);
        
        DisplayResult(userName, numberSquared);
    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
       int result = number * number;
       return result;
    }

    static void DisplayResult(string userName, int numberSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {numberSquared}");
    }

}