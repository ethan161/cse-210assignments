using System;

public class Swimming : Activity
{
    protected int _numberOfLaps = 0;

    public Swimming(string date, int activityLength, int numberOfLaps)
    :  base("Swimming", date, activityLength)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override decimal GetDistance()
    {
        return _numberOfLaps * 50m / 1000m * 0.62m;
    }

    public override decimal GetPace()
    {
        return _activityLength / GetDistance();
    }

    public override decimal GetSpeed()
    {
        return 60m / GetPace();
    }
}