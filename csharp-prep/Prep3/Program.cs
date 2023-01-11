using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);
        int input = 0;

        Console.WriteLine($"What is the magic number? {number}");
        do
        {
            Console.Write("What is your guess? ");
        input = int.Parse(Console.ReadLine());
        if (input > number)
        {
            Console.WriteLine("Lower");
        }
        else if (input < number)
        {
            Console.WriteLine("Higher");
        }
        else if (input == number)
        {
            Console.WriteLine("You guessed it!");
        }
        } while (number != input);
        
    }   
}