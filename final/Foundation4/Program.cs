using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
    }

    public List<Activity> CreateEvents()
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running("01 Apr 2023", 30, 3);
        Cycling cycling = new Cycling("23 Mar 2022", 62, 12);
        Swimming swimming = new Swimming("14 Mar 2023", 68, 21);
        return activities;
    }

    public void DisplayEvents()
    {

    }
}