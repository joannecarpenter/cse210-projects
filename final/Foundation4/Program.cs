using System;

class Program
{
    static void Main(string[] args)
    {  
        Console.WriteLine();
        // Create an activity of each type
        var rActivity = new RunningActivity("29 May 2023", 20, 3);
        var cActivity = new CyclingActivity("30 May 2023", 30, 12);
        var sActivity = new SwimmingActivity("31 May 2023", 30, 25);

        // Add the activities to the list
        var activities = new List<Activity>();
        activities.Add(rActivity);
        activities.Add(cActivity);
        activities.Add(sActivity);
        
        // Iterate through activities list and display GetSummary for each item in the list
        foreach (Activity item in activities)
        {
            double distance = item.CalculateDistance();
            double speed = item.CalculateSpeed();
            double pace = item.CalculatePace();

            item.GetSummary(distance, speed, pace);
        }


    }
}