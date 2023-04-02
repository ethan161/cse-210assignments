using System;

public class Reception : Event
{
    private string _rsvp = "";

    public Reception(string eventTitle, string date, string time, string description, Address address, string rsvp)
    :  base("Reception", eventTitle, date, time, description, address)
    {
        _rsvp = rsvp;
    }

    public override void FullDetails()
    {
        Console.WriteLine($"{_eventTitle}\n{_date} | {_time}\n{_description}\n\nRSVP at: {_rsvp}");
        Console.WriteLine(_address.FormatAddress());
    }
}