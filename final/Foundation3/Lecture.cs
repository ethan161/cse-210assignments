using System;

public class Lecture : Event
{
    private string _speakerName = "";

    private int _eventCapacity = 0;

    public Lecture(string eventTitle, string date, string time, string description, Address address, string speakerName, int eventCapacity)
    :  base("Lecture", eventTitle, date, time, description, address)
    {   
        _speakerName = speakerName;
        _eventCapacity = eventCapacity;
    }

    public override void FullDetails()
    {
        Console.WriteLine($"{_eventTitle}\n{_date} | {_time}\n{_description}\n{_speakerName}\nEvent Capacity: {_eventCapacity}");
        Console.WriteLine(_address.FormatAddress());
    }
}