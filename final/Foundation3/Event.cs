using System;

public abstract class Event
{
    public string _eventTitle = "";

    public string _date = "";

    public string _time = "";

    public string _description = "";

    public Address _address { get; init; }

    public Event(string eventTitle, string date, string time, string description, Address address)
    {
        _eventTitle = eventTitle; 
        _date = date;
        _time = time;
        _description = description;
        _address = address;
    }

    protected abstract string EventType { get; }

    public void StandardDetails()
    {
        // title, description, date, time, and address
        Console.WriteLine($"{_eventTitle}\n{_date} | {_time}\n{_description}\n");
        Console.WriteLine(_address.FormatAddress());
    }

    public abstract void FullDetails();

    public void ShortDescription()
    {
        
        Console.WriteLine($"{EventType}\n{_eventTitle}\n{_date}");
    }
}