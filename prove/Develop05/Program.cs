using System;

class Program
{
    static void Main(string[] args)
    {
        Goal goal = new Goal();
        SimpleGoal simpleGoal = new SimpleGoal();
        EternalGoal eternalGoal = new EternalGoal();
        ChecklistGoal checklistGoal = new ChecklistGoal();
        bool endLoop = false;
        Console.WriteLine("");
        do
        {
            Console.WriteLine("");
            Console.WriteLine($"You have {goal._points} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string programInput = Console.ReadLine();
            switch(programInput)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    endLoop = true;
                    break;
                default:
                    Console.WriteLine("Please enter a digit 1-6.");
                    Thread.Sleep(3000);
                    break;
            }
        } while (endLoop == false);
    }
}