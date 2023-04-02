using System;

public class Running : Activity
{
    protected int _distance = 0;

    public Running(string date, int activityLength, int distance)
    :  base("Running", date, activityLength)
    {
        _distance = distance;
    }

    public override decimal GetDistance()
    {
        return _distance;
    }

    public override decimal GetPace()
    {
        return _activityLength / _distance;
    }

    public override decimal GetSpeed()
    {
        return 60m / GetPace();
    }
}