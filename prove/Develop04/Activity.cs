using System;

public class Activity
{
    public string _name = "";
    public string _description = "";
    public int _duration = 0;
    public int DisplayStartMessage(string activityType, string activityDescription)
    {
        Console.WriteLine($"Welcome to the {activityType} Activity.");
        Console.WriteLine("");
        Console.WriteLine(activityDescription);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session?");
        return _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndMessage(int duration, string activityType)
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Pause(3);
        Console.WriteLine($"You have completed another {duration} seconds of the {activityType} Activity.");
        Pause(6);
    }
    public void Pause(int duration)
    {
        string[] characters = {"/", "-", @"\", "|"};
        int index = 0;
        do {
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(characters[index % 4]);
            index ++;
        } while (index <= duration);

    }
    public void Timer(int duration)
    {
        do {
            Console.Write("\b \b");
            Console.Write(duration);
            duration --;
            Thread.Sleep(1000);
        }  while (duration > 0);

    }
}