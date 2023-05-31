using System;

class CyclingActivity : Activity
{
    // Attributes

    // Constructors
    public CyclingActivity(string date, int activityMinutes, double speed) : base(date, activityMinutes)
    {
        _date = date;
        _activityMinutes = activityMinutes;
        _speed = speed;
    }

    // Methods 
    public override double CalculateDistance()
    {
       return _speed / 60 * _activityMinutes;
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override double CalculatePace()
    {
        return 60 / _speed;
    }
}