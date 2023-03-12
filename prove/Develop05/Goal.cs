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

    public string Name
    {
        get { return _name; }
    }

    public abstract string GetStringRepresentation();

    public abstract void List();

    public abstract int Accomplished();
}