using System;

public class BreathingActivity : Activity
{
    Activity activity = new Activity();
    
    public void RunActivity()
    {
        base._name = "Breathing";
        base._description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on you breathing.";
        DisplayStartMessage(_name, _description);
        Breath();


    }
    public void Breath()
    {
        
    }
}