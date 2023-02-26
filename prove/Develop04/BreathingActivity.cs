using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    :  base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on you breathing.")
    {  
    }

    public void RunActivity()
    {
        DisplayStartMessage();
        Breath();
        DisplayEndMessage();
    }

    public void Breath()
    {
        int count = 0;
        do
        {
            Console.Write("Breathe in...");
            Timer(4);
            Console.WriteLine("");
            Console.Write("Now breathe out...");
            Timer(6);
            Console.WriteLine("");
            count = count + 10;
        } while (count < ActivityDuration);
    }
}