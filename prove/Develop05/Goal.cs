using System;

public abstract class Goal
{
    protected string _name = "";

    protected string _description = "";

    protected int _points = 0;

    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public List<string> goalList = new List<string>();

    public string[] _newGoal;

    public virtual void RecordGoal()
    {
        ListGoals(_newGoal);
    }
    public abstract string GetStringRepresentation();

    public void ListGoals(string[] currentGoals)
    {
        Console.WriteLine("The goals are:");
        int itemNumber = 1;
        foreach (string line in currentGoals)
            {
                string[] items = line.Split("|");
                string x = " ";
                if (bool.Parse(items[4]) == true)
                {
                    x = "X";
                }
                Console.WriteLine($"{itemNumber}. [{x}] {items[1]} ({items[2]})");
                itemNumber ++;
            }
    }
}