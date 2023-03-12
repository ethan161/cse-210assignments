using System;

public class EternalGoal : Goal
{
    public override string[] createGoal()
    {
        _newGoal.Append("EternalGoal");
        base.createGoal();
        return _newGoal;
    }
}