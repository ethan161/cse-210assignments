using System;

public class Cycling : Activity
{

    public decimal _speed = 0;

    public Cycling(string date, int activityLength, decimal speed)
    :  base("Cycling", date, activityLength)
    {
        _speed = speed;
    }

    public override decimal GetDistance()
    {
        return _speed * _activityLength / 60m;
    }

    public override decimal GetPace()
    {
        return 60m / GetSpeed();
    }

    public override decimal GetSpeed()
    {
        return _speed;
    }
}