using System;

public class ReflectingActivity : Activity
{ 
    private string[] _prompts =
    {
        "Think of a time you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions =
    {        
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
    : base ("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void RunActivity()
    {
        DisplayStartMessage();
        Reflect();
        DisplayEndMessage();
    }

    public void Reflect()
    {
        RandomList promptList = new RandomList(_prompts);
        RandomList questionList = new RandomList(_questions);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($" --- {promptList.Next()} --- ");
        Console.WriteLine("");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in: ");
        Timer(6);
        Console.Clear();
        int count = 0;
        do 
        {
            Console.WriteLine($"> {questionList.Next()} ");
            Pause(10);
            count = count + 10;
        } while (count < ActivityDuration);

        Console.WriteLine("");
    }
}