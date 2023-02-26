using System;

public class Activity
{
    private string _name = "";

    private string _description = "";

    private int _activityDuration = 0;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int ActivityDuration
    {
        get
        {
            return _activityDuration;
        }
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        _activityDuration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        Pause(6);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        Pause(3);
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_name} Activity.");
        Pause(6);
    }

    public void Pause(int pauseDuration)
    {
        string[] characters = {"/", "-", @"\", "|"};
        int index = 0;
        do {
            Console.Write(characters[index % 4]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            index ++;
        } while (index <= pauseDuration);
        Console.WriteLine("\b \b");
    }

    public void Timer(int timerDuration)
    {
        do {
            Console.Write(timerDuration);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            timerDuration --;
        }  while (timerDuration > 0);
    }
}