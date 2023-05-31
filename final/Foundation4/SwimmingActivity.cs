using System;

class SwimmingActivity : Activity
{
    // Attributes
    private int _laps = 0;

    // Constructors
    public SwimmingActivity(string date, int activityMinutes, int laps) : base(date, activityMinutes)
    {
        _date = date;
        _activityMinutes = activityMinutes;
        _laps = laps;
    }

    // Methods 
    public override double CalculateDistance()
    {
       return _laps * 50 * 0.00062137;
    }
    public override double CalculateSpeed()
    {
        return (_laps * 50 * 0.00062137) / _activityMinutes * 60;
    }
    public override double CalculatePace()
    {
        return _activityMinutes / (_laps * 50 * 0.00062137);
    }
}