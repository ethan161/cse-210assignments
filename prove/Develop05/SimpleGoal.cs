using System;

public class SimpleGoal : Goal
{
    private bool _completion = false;
    public SimpleGoal(string name, string description, int points, bool isCompleted)
    :  base(name, description, points)
    {
        _completion = isCompleted;
    }

    public override int Accomplished()
    {
        _completion = true;
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple|{_name}|{_description}|{_points}|{_completion}";
    }

    public override void List()
    {
        string checkbox = "[ ]";
        if (_completion)
        {
            checkbox = "[X]";
        }
        Console.WriteLine($"{checkbox} {_name} ({_description})");
    }
}