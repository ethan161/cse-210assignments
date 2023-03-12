using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    :  base(name, description, points)
    {
    }

    public EternalGoal(string[] items)
    :  this(items[0], items[1], int.Parse(items[2]))
    {
    }

    public override int Accomplished()
    {
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal|{_name}|{_description}|{_points}";
    }

    public override void List()
    {
        string checkbox = "[ ]";
        Console.WriteLine($"{checkbox} {_name} ({_description})");
    }
}