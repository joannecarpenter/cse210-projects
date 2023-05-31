using System;

abstract class Activity
{
    // Attributes
    protected int _activityMinutes = 0;
    protected string _date = "";
    protected double _distance = 0, _speed = 0, _pace = 0;

    // Constructors
    public Activity(string date, int activityMinutes)
    {
        _date = date;
        _activityMinutes = activityMinutes;
    }

    // Methods 
    public virtual double CalculateDistance()
    {
       return -1;
    }
    public virtual double CalculateSpeed()
    {
        return -1;
    }
    public virtual double CalculatePace()
    {
        return -1;
    }
    public void GetSummary(double distance, double speed, double pace)
    {
        _distance = Math.Round(distance, 2);
        _speed = Math.Round(speed, 2);
        _pace = Math.Round(pace, 2);
        
        Console.WriteLine($"{_date} ({_activityMinutes} min)- Distance {_distance} miles, Speed {_speed} mph, Pace: {_pace} min per mile");
    }
}