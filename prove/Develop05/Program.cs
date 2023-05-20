using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome Statement
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("*** Welcome to Eternal Quest Goal Tracker! ***");
        Console.WriteLine();
        
        // Create new instance of Goal for use throughout the Main
        Goal goal = new Goal();
  
        // Display Main Menu and receive user response
        string userChoice = "";
        int goalPoints = 0;
        do{
            // Calculate and display the number of points  
            goal.CalculatePoints(goalPoints);
            Console.WriteLine();
            
            List<string> menuOptions = new List<string>()
            {
                "Menu Options:",
                "1.	Create New Goal",
                "2.	List Goals",
                "3.	Save Goals",
                "4.	Load Goals",
                "5.	Record Event",
                "6.	Quit"
            };
            foreach (string item in menuOptions){
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();       

            // Peform action based on user response
            if (userChoice == "1"){
                Console.WriteLine("Let's create a new goal!");
                Menu goalMenu = new Menu();
                goalMenu.CreateGoal();
            }
            else if (userChoice == "2"){
                Console.WriteLine("Let's list your goals!");
                goal.DisplayGoalsList();
            }
            else if (userChoice == "3"){
                Console.WriteLine("Let's save your goals!");
                // goal.SaveToCSV();
            }
            else if (userChoice == "4"){
                Console.WriteLine("Let's load your goals!");
                // goal.LoadToCSV();
            }
            else if (userChoice == "5"){
                Console.WriteLine("Let's record an event!");
                // goal.RecordEvent();
            }
            else if (userChoice == "6"){
                Console.WriteLine("Great job taking time to work on your goals today! Now go out and put those plans into action!");
            }
            Console.WriteLine();
        } while (userChoice != "6");
        
    }
}