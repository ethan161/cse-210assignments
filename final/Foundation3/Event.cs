using System;

public abstract class Event
{
    protected string _eventType = "";

    protected string _eventTitle = "";

    protected string _date = "";

    protected string _time = "";

    protected string _description = "";

    protected Address _address { get; init; }

    protected Event(string eventType, string eventTitle, string date, string time, string description, Address address)
    {
        _eventType = eventType;
        _eventTitle = eventTitle; 
        _date = date;
        _time = time;
        _description = description;
        _address = address;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"{_eventTitle}\n{_date} | {_time}\n{_description}\n");
        Console.WriteLine(_address.FormatAddress());
    }

    public abstract void FullDetails();

    public void ShortDescription()
    {
        Console.WriteLine($"{_eventType}\n{_eventTitle}\n{_date}");
    }
}