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
            outputFile.WriteLine(goal.goalList);
        }
        Console.WriteLine("File successfully saved.");
    }
    public void loadFile()
    {
        Console.Write("What file you like to load? ");
        string filename = Console.ReadLine();
        string[] loadedFile = File.ReadAllLines(filename);
        
        Console.WriteLine("Goals successfully loaded.");
    }
}