using System;

public class ListingActivity : Activity
{
    public ListingActivity()
    : base ("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    Random rnd = new Random();
    string[] prompts = {"Who are people that you appreciate?",
                        "What are personal strengths of yours?",
                        "Who are people that you have helped this week?",
                        "When have you felt the Holy Ghost this month?",
                        "Who are some of your personal heroes?"};
    public void RunActivity()
    {
        int duration = DisplayStartMessage(_name, _description);
        List(duration);
        DisplayEndMessage(_duration, _description);
    }

    public void List(int duration)
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($" --- {prompts[rnd.Next(0, prompts.Length)]} --- ");
        Console.WriteLine("");
        Console.WriteLine("You may begin in: ");
        Timer(5);
        int count = 0;
        List<string> items = new List<string>();
        do 
        {
            Console.WriteLine("> ");
            items.Add(Console.ReadLine());
        } while (count < duration);
        Console.WriteLine($"You listed {items.Count} items!");
    }
}