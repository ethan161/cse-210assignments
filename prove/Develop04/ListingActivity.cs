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
                        "Who are some of your personal heroes?",};
    public void RunActivity()
    {
        int duration = DisplayStartMessage(_name, _description);
        List(duration);
    }
    
    public void List(int duration)
    {
        
    }
}