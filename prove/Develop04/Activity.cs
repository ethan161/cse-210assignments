using System;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int DisplayStartMessage(string activityType, string activityDescription)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {activityType} Activity.");
        Console.WriteLine("");
        Console.WriteLine(activityDescription);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        Pause(6);
        return _duration;
    }

    public void DisplayEndMessage(int duration, string activityType)
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        Pause(3);
        Console.WriteLine($"You have completed another {duration} seconds of the {activityType} Activity.");
        Pause(6);
    }

    public void Pause(int duration)
    {
        string[] characters = {"/", "-", @"\", "|"};
        int index = 0;
        do {
            Console.Write(characters[index % 4]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            index ++;
        } while (index <= duration);
        Console.WriteLine("\b \b");
    }

    public void Timer(int duration)
    {
        do {
            Console.Write(duration);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            duration --;
        }  while (duration > 0);
    }
}