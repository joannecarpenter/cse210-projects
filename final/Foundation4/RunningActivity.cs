using System;

class RunningActivity : Activity
{
    // Attributes

    // Constructors
    public RunningActivity(string date, int activityMinutes, int distance) : base(date, activityMinutes)
    {
        _date = date;
        _activityMinutes = activityMinutes;
        _distance = distance;
    }

    // Methods 
    public override double CalculateDistance()
    {
       return _distance;
    }
    public override double CalculateSpeed()
    {
        return _distance / _activityMinutes * 60;
    }
    public override double CalculatePace()
    {
        return _activityMinutes / _distance;
    }
}