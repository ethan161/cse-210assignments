using System;

class Program
{
    static void Main(string[] args)
    {
        Goal goal = new Goal();
        SimpleGoal simpleGoal = new SimpleGoal();
        EternalGoal eternalGoal = new EternalGoal();
        ChecklistGoal checklistGoal = new ChecklistGoal();
        GoalChecker goalChecker = new GoalChecker();
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
                    break;
                case "2":
                    Console.WriteLine("The goals are:");
                    int itemNumber = 1;
                    foreach (string line in goal.goalList)
                    {
                        string[] items = line.Split("|");
                        string x = " ";
                        if (bool.Parse(items[4]) == true)
                        {
                            x = "X";
                        }
                        Console.WriteLine($"{itemNumber}. [{x}] {items[1]} ({items[2]})");
                        itemNumber ++;
                    }
                    Console.WriteLine("");
                    break;
                case "3":
                    goalChecker.saveToFile();
                    break;
                case "4":
                    goalChecker.loadFile();
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