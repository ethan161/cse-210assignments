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
    public override string GetStringRepresentation()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_currentCompletions}|{_neededCompletions}|{_bonusPoints}";
    }
}