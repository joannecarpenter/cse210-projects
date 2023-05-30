using System;

class Reception : Event
{
    // Attributes
    private string _emailAddress = "";

    // Constructors
    public Reception(string title, string description, string date, string time, Address address, string emailAddress) : base(title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _emailAddress = emailAddress;
    }  

    // Methods 
    public override void GenerateFullDetails()
    {
        // Lists standard details, plus type of event and information specific to that event type.
        GenerateStandardDetails();
        // For receptions this includes an email for RSVP. 
        Console.WriteLine($"Email for RSVP: {_emailAddress}");
    }
}