using System;

public class Outdoor : Event
{
    private string _weather = "";

    public Outdoor(string eventTitle, string date, string time, string description, Address address, string weather)
    :  base("Outdoor", eventTitle, date, time, description, address)
    {   
        _weather = weather;
    }

    public override void FullDetails()
    {
        Console.WriteLine($"{_eventTitle}\n{_date} | {_time}\n{_description}\nWeather Forecast: {_weather}");
        Console.WriteLine(_address.FormatAddress());
    }
} 