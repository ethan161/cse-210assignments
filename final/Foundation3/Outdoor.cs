using System;

public class Outdoor : Event
{
    public string _weather = "";

    public Outdoor(string eventTitle, string date, string time, string description, Address address, string weather)
    :  base(eventTitle, date, time, description, address)
    {
    }

    protected override string EventType => "Outdoor";
    public override void FullDetails()
    {
        Console.WriteLine($"{_eventTitle}\n{_date} | {_time}\n{_description}\nWeather Forecast: {_weather}");
        Console.WriteLine(_address.FormatAddress());
    }
} 