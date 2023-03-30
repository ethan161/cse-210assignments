using System;

public abstract class Event
{
    public string _eventTitle = "";

    public string _date = "";

    public string _time = "";

    public string _description = "";

    public Address address { get; init; }

    public Event(string eventTitle, string date, string time, string description, Address address)
    {
        _eventTitle = eventTitle;
        _date = date;
        _time = time;
        _description = description;
    }

    public void StandardDetails()
    {
        // title, description, date, time, and address
        Console.WriteLine($"{_eventTitle}\n{_date} | {_time}\n{_description}");
        Console.WriteLine(address.FormatAddress());
    }

    public abstract void FullDetails();

    public void ShortDescription()
    {
        // type of event, title, date
        Console.WriteLine($"");
    }
}