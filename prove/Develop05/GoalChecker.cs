using System;

public class GoalChecker
{
    public int PointsEarned
    {
        get; 
        set;
    }

    public List<Goal> Goals { get; } = new List<Goal>();

    public void ListGoals()
    {
        for (int index = 0; index < Goals.Count; index++)
        {
            Console.Write($"{index+1}. ");
            Goals[index].List();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(PointsEarned);
            foreach (Goal goal in Goals)
            {
                string line = goal.GetStringRepresentation();
                outputFile.WriteLine(line);
            }
        }
    }
    public void LoadFile(string filename)
    {
        Goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        PointsEarned = int.Parse(lines[0]);
        for (int index = 1; index < lines.Length; index++)
        {
            string line = lines[index];
            string[] items = line.Split("|");
            string goalType = items[0];
            if (goalType == "Simple")
            {
                // $"Simple|{_name}|{_description}|{_points}|{_completion}"
                string goalName = items[1];
                string goalDescription = items[2];
                int goalPoints = int.Parse(items[3]);
                bool goalCompletion = bool.Parse(items[4]);
                Goal goal = new SimpleGoal(goalName, goalDescription, goalPoints, goalCompletion);
                Goals.Add(goal);
            }
            else if (goalType == "Eternal")
            {
                // $"Simple|{_name}|{_description}|{_points}
                string goalName = items[1];
                string goalDescription = items[2];
                int goalPoints = int.Parse(items[3]);
                Goal goal = new EternalGoal(goalName, goalDescription, goalPoints);
                Goals.Add(goal);
            }
            else if (goalType == "Checklist")
            {
                // {_name}|{_description}|{_points}|{_totalCompletions}|{_neededCompletions}|{_bonusPoints}
                string goalName = items[1];
                string goalDescription = items[2];
                int goalPoints = int.Parse(items[3]);
                int goalCompletions = int.Parse(items[4]);
                int goalNeededCompletions = int.Parse(items[5]);
                int goalBonusPoints = int.Parse(items[6]);                
                Goal goal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalCompletions, goalNeededCompletions, goalBonusPoints);
                Goals.Add(goal);
            }
        }
    }
}