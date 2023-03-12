using System;

public class Goal
{
    private string _name = "";

    private string _description = "";

    public int _points = 0;

    private bool _completion = false;

    public void createGoal(string name, string description, int points)
    {
        bool goalLoop = false;
        do 
        {
            Console.WriteLine("The types of goals are: ");
            Console.WriteLine("   1. Simple Goal");
            Console.WriteLine("   2. Eternal Goal");
            Console.WriteLine("   3. Checklist Goal");
            Console.WriteLine("Which type of goal would you like to create? ");
            string goalInput = Console.ReadLine();
            switch(goalInput)   
            {
                case "1":

                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Please enter a digit 1-3.");
                    Thread.Sleep(3000);
                    break;
            }
        } while (goalLoop == false);
    }
}