using System;

class Program
{
    static GoalChecker _goalChecker = new GoalChecker();
    static void Main(string[] args)
    {
        bool endLoop = false;
        Console.WriteLine("");
        do
        {
            Console.WriteLine("");
            Console.WriteLine($"You have {_goalChecker.PointsEarned} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            string programInput = Console.ReadLine();
            switch(programInput)
            {
                case "1":
                    Goal goal = CreateGoal();
                    _goalChecker.Goals.Add(goal);
                    break;
                case "2":
                    ListGoal();
                    break;
                case "3":
                    SaveFile();
                    break;
                case "4":
                    LoadFile();
                    break;
                case "5":
                    RecordEvent();
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

    public static Goal CreateGoal()
    {
        Goal goal = null;
        do 
        {
            Console.WriteLine("The types of goals are: ");
            Console.WriteLine("   1. Simple Goal");
            Console.WriteLine("   2. Eternal Goal");
            Console.WriteLine("   3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string goalInput = Console.ReadLine();
            
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("How many points are associated with this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());
            if (goalInput == "1")
            {
                goal = new SimpleGoal(goalName, goalDescription, goalPoints, false);
            }
            else if (goalInput == "2")
            {
                goal = new EternalGoal(goalName, goalDescription, goalPoints);
            }
            else if (goalInput == "3")
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int neededCompletions = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(goalName, goalDescription, goalPoints, 0, neededCompletions, bonusPoints);
            }
            else
            {
                Console.WriteLine("Please enter a digit 1-3.");
            }
        } while (goal == null);

        return goal;
    }

    public static void ListGoal()
    {
        Console.WriteLine("The goals are:");
        _goalChecker.ListGoals();
    }

    public static void LoadFile()
    {
        Console.Write("What file would you like to load? ");
        string filename = Console.ReadLine();
        _goalChecker.LoadFile(filename);
    }

    public static void SaveFile()
    {
        Console.Write("What file would you like to save this under? ");
        string filename = Console.ReadLine();
        _goalChecker.SaveToFile(filename);
    }

    public static void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (int index = 0; index < _goalChecker.Goals.Count; index++)
        {
            Console.WriteLine($"{index+1}. {_goalChecker.Goals[index].Name}");
        }
        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;
        int pointEarned = _goalChecker.Goals[goalNumber].Accomplished();
        Console.WriteLine($"Congratulations! You have earned {pointEarned} points!");
        _goalChecker.PointsEarned += pointEarned;
        Console.WriteLine($"You now have {_goalChecker.PointsEarned} points.");
    }
}