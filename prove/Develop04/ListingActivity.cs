using System;

public class ListingActivity : Activity
{
    public ListingActivity()
    : base ("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    Random rnd = new Random();
    TimeSpan currentTime = DateTime.Now.TimeOfDay;
    string[] prompts = {"Who are people that you appreciate?",
                        "What are personal strengths of yours?",
                        "Who are people that you have helped this week?",
                        "When have you felt the Holy Ghost this month?",
                        "Who are some of your personal heroes?"};
    public void RunActivity()
    {
        int duration = DisplayStartMessage(_name, _description);
        List(duration);
        DisplayEndMessage(_duration, _name);
    }

    public void List(int duration)
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($" --- {prompts[rnd.Next(0, prompts.Length)]} --- ");
        Console.WriteLine("");
        Console.WriteLine("You may begin in: ");
        Timer(5);
        List<string> items = new List<string>();
        DateTime date2 = DateTime.Now;
        DateTime date1 = DateTime.Now;
        TimeSpan timeDifference = date1.Subtract(date2);
        do 
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
            date1 = DateTime.Now;
            timeDifference = date1.Subtract(date2);
        } while (timeDifference.Seconds < duration);
        Console.WriteLine("");
        Console.WriteLine($"You listed {items.Count} items!");
    }
}