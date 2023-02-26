using System;

public class ListingActivity : Activity
{
    private string[] _prompts = 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    : base ("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void RunActivity()
    {
        DisplayStartMessage();
        List();
        DisplayEndMessage();
    }

    public void List()
    {
        RandomList promptList = new RandomList(_prompts);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($" --- {promptList.Next()} --- ");
        Console.WriteLine("");
        Console.WriteLine("You may begin in: ");
        Timer(5);
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        do 
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        } while (DateTime.Now.Subtract(startTime).Seconds < ActivityDuration);

        Console.WriteLine("");
        Console.WriteLine($"You listed {items.Count} items!");
    }
}