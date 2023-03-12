using System;

public class Goal
{
    private string _name = "";

    private string _description = "";

    public int _points = 0;

    private bool _completion = false;

    public List<string> goalList = new List<string>();
    string[] newGoal;
    public string[] createGoal(string name, string description, int points)
    {
        Console.WriteLine("What is the name of your goal? ");
        newGoal.Append(Console.ReadLine());
        Console.WriteLine("What is a short description of it? ");
        newGoal.Append(Console.ReadLine());
        Console.WriteLine("How many points are associated with this goal? ");
        newGoal.Append(Console.ReadLine());
        _completion = false;
        newGoal.Append(Console.ReadLine());
        return newGoal;
    }
}