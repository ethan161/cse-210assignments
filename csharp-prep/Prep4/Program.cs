using System;
using System.Collections.Generic;

class Program

{
    static void Main(string[] args)
    
    {
        List<int> numbers = new List<int>();
        int input;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        } while (input != 0);
        int length = numbers.Count;
        int sum;
        sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/length}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}