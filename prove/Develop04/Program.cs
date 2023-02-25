using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        bool endLoop = false;
        
        while (endLoop == false)
        {   
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            int activityInput = int.Parse(Console.ReadLine());
            switch (activityInput)
            {
                case 1:
                    breathingActivity.RunActivity();
                    break;
                case 2:
                    reflectingActivity.RunActivity();
                    break;
                case 3:
                    listingActivity.RunActivity();
                    break;
                case 4:
                    endLoop = true;
                    break;
            }
        }
    }
}