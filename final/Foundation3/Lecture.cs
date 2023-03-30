using System;

public class Lecture : Event
{
    public string _speakerName = "";

    public int eventCapacity = 0;

    public Lecture(string eventTitle, string date, string time, string description, Address address, string speakerName, int eventCapacity)
    :  base(eventTitle, date, time, description, address)
    {
    }
        // title, description, date, time, address, lectures: speaker name, receptions: email for rsvp, outdoor: weather
    public override void FullDetails()
    {
        Console.WriteLine($"{_eventTitle}\n{_date} | {_time}\n{_description}\n{_speakerName}");
        Console.WriteLine(address.FormatAddress());
    }
}