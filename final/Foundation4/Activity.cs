using System;

public abstract class Activity
{
    protected string _date = "";

    protected int _activityLength = 0;

    protected string _activityType = "";

    public Activity(string activityType, string date, int activityLength)
    {
        _activityType = activityType;
        _date = date;
        _activityLength = activityLength;
    }
    
    public string GetSummary()
    {
        decimal distance = Math.Round(GetDistance(), 2);
        decimal speed = Math.Round(GetSpeed(), 2);
        decimal pace = Math.Round(GetPace(), 2);
        return ($"{_date} {_activityType} ({_activityLength} min)- Distance {distance} miles, Speed {speed} mph, Pace: {pace} min per mile");
    }

    public abstract decimal GetDistance();

    public abstract decimal GetSpeed();

    public abstract decimal GetPace();
}