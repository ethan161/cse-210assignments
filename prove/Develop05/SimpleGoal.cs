using System;

public class SimpleGoal : Goal
{
    public override string[] createGoal()
    {
        _newGoal.Append("SimpleGoal");
        base.createGoal();
        _completion = false;
        return _newGoal;
    }
}