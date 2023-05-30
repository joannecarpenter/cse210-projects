using System;

class OutdoorGathering : Event
{
    // Attributes
    private string _weather = "";

    // Constructors
    public OutdoorGathering(string title, string description, string date, string time, string weather, Address address) : base(title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _weather = weather;
    }

    // Methods
    public override void GenerateFullDetails()
    {
        // Lists standard details, plus type of event and information specific to that event type.
        GenerateStandardDetails();
        // For outdoor gatherings, this includes a statement of the weather.
        Console.WriteLine($"Anticipated Weather: {_weather}"); 
    } 
}