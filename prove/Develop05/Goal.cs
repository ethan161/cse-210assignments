using System;

public class Goal
{
    private string _name = "";

    private string _description = "";

    public int _points = 0;

    public bool _completion = false;

    public List<string> goalList = new List<string>();
    public string[] _newGoal;
    public virtual string[] createGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _newGoal.Append($"{Console.ReadLine()}|");
        Console.WriteLine("What is a short description of it? ");
        _newGoal.Append($"{Console.ReadLine()}|");
        Console.WriteLine("How many points are associated with this goal? ");
        _newGoal.Append($"{Console.ReadLine()}|");
        return _newGoal;
    }

    public virtual void RecordGoal()
    {

    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        int itemNumber = 1;
        foreach (string line in goalList)
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