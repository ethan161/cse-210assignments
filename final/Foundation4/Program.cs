using System;

public class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        List<Activity> activities = program.CreateEvents();

        Console.Clear();
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }

    public List<Activity> CreateEvents()
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running("01 Apr 2023", 30, 3);
        Cycling cycling = new Cycling("23 Mar 2022", 62, 12);
        Swimming swimming = new Swimming("14 Mar 2023", 68, 21);
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        return activities;
    }
}