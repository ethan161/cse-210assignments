using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please insert the percentage you earned: ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);
        string letter = "";

        if (number >= 90)
            {
                letter = "A";
            }
        else if (number < 90 && number >=80)
            {
                letter = "B";
            }
        else if (number < 80 && number >= 70)
            {
                letter = "C";
            }
        else if (number < 70 && number >= 60)
            {
                letter = "D";
            }
        else if (number < 60)
            {
                letter = "F";
            }

        Console.WriteLine($"You earned a(n) {letter}.");
        if (number >= 70)
        {
            Console.WriteLine("You passed.");
        }
        else
        {
            Console.WriteLine("You did not pass.");
        }
}
}