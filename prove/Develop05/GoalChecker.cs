using System;

public class GoalChecker
{
    Goal goal = new Goal();
    public void saveToFile()
    {
        Console.WriteLine("What file would you like to save this under? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine();
        }
        Console.WriteLine("File successfully saved.");
    }
    public void loadFile()
    {
        Console.WriteLine("What file you like to load? ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        foreach {string line in lines}
        {
            lines[0] = _name
        }
        Console.WriteLine("Goals successfully loaded.");
    }
}