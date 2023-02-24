using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    :  base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on you breathing.")
    {  
    }
    
    public void RunActivity()
    {
        int duration = DisplayStartMessage(_name, _description);
        Breath(_duration);
        DisplayEndMessage(duration, base._name);
    }

    public void Breath(int duration)
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Pause(6);
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
        } while (count < duration);
    }
}