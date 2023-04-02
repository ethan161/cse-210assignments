using System;

public class Lecture : Event
{
    public string _speakerName = "";

    public int eventCapacity = 0;

    public Lecture(string eventTitle, string date, string time, string description, Address address, string speakerName, int eventCapacity)
    :  base(eventTitle, date, time, description, address)
    {
    }

    protected override string EventType => "Lecture";

    public override void FullDetails()
    {
        Console.WriteLine($"{_eventTitle}\n{_date} | {_time}\n{_description}\n{_speakerName}");
        Console.WriteLine(_address.FormatAddress());
    }
}