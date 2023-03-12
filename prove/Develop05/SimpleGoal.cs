using System;

public class SimpleGoal : Goal
{
    private bool _isCompleted = false;

    public SimpleGoal(string name, string description, int points, bool isCompleted)
    :  base(name, description, points)
    {
        _isCompleted = isCompleted;
    }

    public SimpleGoal(string[] items)
    :  this(items[0], items[1], int.Parse(items[2]), bool.Parse(items[3]))
    {
    }

    public override int Accomplished()
    {
        _isCompleted = true;
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple|{_name}|{_description}|{_points}|{_isCompleted}";
    }

    public override void List()
    {
        string checkbox = "[ ]";
        if (_isCompleted)
        {
            checkbox = "[X]";
        }
        Console.WriteLine($"{checkbox} {_name} ({_description})");
    }
}