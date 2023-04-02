using System;

public class Swimming : Activity
{
    public int _numberOfLaps = 0;

    public Swimming(string date, int activityLength, int numberOfLaps)
    :  base(date, activityLength)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override void GetSummary()
    {
        throw new NotImplementedException();
    }
}