using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        foreach (string line in File.ReadLines("scriptures.txt"))
        {
            string[] items = line.Split("|");
            Reference newReference = new Reference(items[0], int.Parse(items[1]), items[2]);
            Scripture newScripture = new Scripture(newReference, items[3]);
            scriptures.Add(newScripture);
        }

        Random rnd = new Random();
        Scripture scripture = scriptures[rnd.Next(0,scriptures.Count)];
        string input;
        do
        {
            scripture.Display();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            input = Console.ReadLine();
            if (input != "quit")
            {
                for (int i = 0; i < rnd.Next(3,6); i++)
                {
                    List<int> visibleIndexes = scripture.GetVisibleWordIndexes();
                    int index = rnd.Next(0, visibleIndexes.Count);
                    scripture.HideWord(visibleIndexes[index]);
                    if (scripture.AreAllHidden())
                    {
                        scripture.Display();
                        break;
                    }
                }
            }
        } while (input != "quit" && !scripture.AreAllHidden());
    }
}