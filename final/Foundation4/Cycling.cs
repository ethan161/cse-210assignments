using System;

public class Cycling : Activity
{

    public int _speed = 0;

    public Cycling(string date, int activityLength, int speed)
    :  base(date, activityLength)
    {
        _speed = speed;
    }

    public override void GetSummary()
    {
        throw new NotImplementedException();
    }
}