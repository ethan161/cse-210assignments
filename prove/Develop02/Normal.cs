using System;
using System.IO;

class Normal
{
    static void Main(string[] args)
    {
        bool doLoop = true;
        Console.WriteLine("Welcome to the journal app!");
        
        do {
            Console.WriteLine("");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load a journal file");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            string input = Console.ReadLine();
            Console.WriteLine("");
            if (input == "1")
            {
                Journal newJournal = new Journal();
                newJournal._newEntry = newJournal.newEntry();                        
            }
            else if (input == "2")
            {
                Console.WriteLine($"");
            }
            else if (input == "3")
            {
                
            }
            else if (input == "4")
            {
                Entry readEntry = new Entry();
                string[] lines = readEntry.readFile();
                Console.WriteLine($"{lines}");
            }
            else if (input == "5")
            {
                doLoop = false;
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        } while (doLoop == true);
        
    }
}