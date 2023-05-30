using System;

class Lecture : Event
{
    // Attributes
    private string _speaker = "";
    private int _capacity = 0;

    // Constructors
    public Lecture(string title, string description, string date, string time, string speaker, int capacity, Address address) : base(title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _speaker = speaker;
        _capacity = capacity;
    }

    // Methods
    public override void GenerateFullDetails()
    {
        // Lists standard details, plus type of event and information specific to that event type.
        GenerateStandardDetails();
        // For lectures, this includes the speaker name and capacity. 
        Console.WriteLine($"Speaker: {_speaker} \nCapacity: {_capacity}");
    }
}