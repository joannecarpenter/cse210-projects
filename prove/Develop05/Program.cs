using System;
// --- Eternal Quest Goal Tracker ---

// --- Creativity That Exceeds Requirements ---
// * Created a welcome message when program begins
// * Created a closing message for when user chooses to quit the program
// * Created guiding messages throughout that confirm each selection made by the user from the menus

class Program
{
    static void Main(string[] args)
    {
        // Welcome Statement
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("*** Welcome to Eternal Quest Goal Tracker! ***");
        Console.WriteLine();

        // Create new instance of each goal class for use throughout the main program
        SimpleGoal simpleGoal = new SimpleGoal("", "", 0, false);
        EternalGoal eternalGoal = new EternalGoal("", "", 0);
        ChecklistGoal checklistGoal = new ChecklistGoal("", "", 0, 0, 0, 0);
        // Create new instance of AllGoals class to allow access to _goals list and other functionality
        AllGoals allGoals = new AllGoals();

        // Display Main Menu and receive user response
        string userChoice = "";
        do
        {
            // Display the total number of points
            int totalPoints = allGoals.GetTotalPoints();
            Console.WriteLine($"You have {totalPoints} points.");
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
            foreach (string item in menuOptions)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            // Perform action based on user response
            if (userChoice == "1")
            {
                Console.WriteLine("Let's create a new goal!");
                // Display the goal menu for user goal choice
                Console.WriteLine();
                List<string> goalMenu = new List<string>()
                {
                    "The types of Goals are:",
                    "1.	Simple Goal",
                    "2.	Eternal Goal",
                    "3.	Checklist Goal"
                };
                foreach (string item in goalMenu)
                {
                    Console.WriteLine($"{item}");
                };
                // Collect user input for goal choice
                Console.WriteLine();
                Console.Write("Select a choice from the menu: ");
                string _goalChoice = Console.ReadLine();
                Console.WriteLine();
                // Respond according to user input and create the desired goal
                if (_goalChoice == "1")
                {
                    Console.WriteLine("You have chosen to create a Simple Goal.");  // <--used for debugging
                    simpleGoal.CreateGoal();
                    allGoals.AddToGoalsList(simpleGoal);
                }
                else if (_goalChoice == "2")
                {
                    Console.WriteLine("You have chosen to create an Eternal Goal.");   // <--used for debugging
                    eternalGoal.CreateGoal();
                    allGoals.AddToGoalsList(eternalGoal);
                }
                else if (_goalChoice == "3")
                {
                    Console.WriteLine("You have chosen to create a Checklist Goal.");   // <--used for debugging
                    checklistGoal.CreateGoal();
                    allGoals.AddToGoalsList(checklistGoal);
                }
            }
            else if (userChoice == "2")
            {
                Console.WriteLine("Let's list your goals!");
                // List all goals
                allGoals.DisplayGoalsList();
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("Let's save your goals!");
                // Save all goals as a csv
                allGoals.SaveToCSV();
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("Let's load your goals!");
                // Load all goals from a csv
                allGoals.LoadFromCSV();

            }
            else if (userChoice == "5")
            {
                Console.WriteLine("Let's record an event!");
                // Record a goal completion event
                allGoals.RecordEvent();
            }
            else if (userChoice == "6")
            {
                Console.WriteLine("Great job taking time to work on your goals today! Now go out and put those plans into action!");
            }

            Console.WriteLine();
        } while (userChoice != "6");

    }
}