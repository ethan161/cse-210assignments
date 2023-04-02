using System;

public abstract class Activity
{
    public string _date = "";

    public int _activityLength = 0;

    public Activity(string date, int activityLength)
    {
        _date = date;
        _activityLength = activityLength;
    }
    public abstract void GetSummary();
    
    public void CalculateActivityInformation()
    {

    }
}