using System;

public class ChecklistGoal : Goal
{
    private int _neededCompletions = 0;

    private int _bonusPoints = 0;

    private int _currentCompletions = 0;

    public ChecklistGoal(string name, string description, int points, int currentCompletions, int neededCompletions, int bonusPoints)
    :  base(name, description, points)
    {
        _currentCompletions = currentCompletions;
        _neededCompletions = neededCompletions;
        _bonusPoints = bonusPoints;
    }

    public ChecklistGoal(string[] items)
    :  this(items[0], items[1], int.Parse(items[2]), int.Parse(items[3]), int.Parse(items[4]), int.Parse(items[5]))
    {
    }

    public override int Accomplished()
    {
        _currentCompletions++;
        if (_currentCompletions == _neededCompletions)
        {
            return _points + _bonusPoints;
        }
        else
        {
            return _points;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_currentCompletions}|{_neededCompletions}|{_bonusPoints}";
    }

    public override void List()
    {
        string checkbox = "[ ]";
        if (_currentCompletions >= _neededCompletions)
        {
            checkbox = "[X]";
        }
        Console.WriteLine($"{checkbox} {_name} ({_description}) -- Currently completed: {_currentCompletions}/{_neededCompletions}");
    }
}