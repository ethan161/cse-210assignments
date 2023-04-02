using System;

public class Running : Activity
{
    int _distance = 0;

    public Running(string date, int activityLength, int distance)
    :  base(date, activityLength)
    {
        _distance = distance;
    }
    public override void GetSummary()
    {
        throw new NotImplementedException();
    }
}