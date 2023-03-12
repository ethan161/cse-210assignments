using System;

public class ChecklistGoal : Goal
{
    Goal goal = new Goal();
    public override string[] createGoal()
    {
        _newGoal.Append("ChecklistGoal");
        base.createGoal();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        goal._newGoal.Append($"{Console.ReadLine()}|");
        goal._newGoal.Append("0");
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        goal._newGoal.Append($"{Console.ReadLine()}|");
        return _newGoal;
    }
}