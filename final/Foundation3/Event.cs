using System;

abstract class Event
{
    // Attributes
    protected string _title = "";
    protected string _description = "";
    protected string _date = "";
    protected string _time = "";
    protected string _eventType = "";
    protected Address _address;

    // Constructors
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _date = date;
        _time = time;
        _address = address;    
    }

    // Methods 
    public void GenerateStandardDetails()
    {
       
       // Lists the title, description, date, time, and address.
       Console.WriteLine($"Event Title: {_title} \nEvent Description: {_description} \nEvent Date: {_date} \nEvent Time: {_time} \nEvent Address: {_address.DisplayAddress()}");
    }

    public virtual void GenerateFullDetails()
    {
        // Lists standard details, plus type of event and information specific to that event type.
        // This can be a virtual method that is overriden in the other classes
    }
    public void GenerateShortDescription(string eventType)
    {
        // Lists the type of event, title, and the date
        _eventType = eventType;
        Console.WriteLine($"Event Type: {_eventType} \nEvent Title: {_title} \nEvent Date: {_date}");
        
    }
    
    public void getTitle(string title)
    {
        // Gets the event title for the address class that is not inherited
        _title = title;
    }
}