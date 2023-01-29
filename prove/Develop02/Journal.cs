using System;

public class Journal 
{
    public string _newEntry;
    public string newEntry() {
        PromptGenerator newPrompt = new PromptGenerator();
        newPrompt.showPrompt();
        Console.Write("> ");
        string inputtedEntry = Console.ReadLine();
        return inputtedEntry;
    }
    public string createEntry()
    {
        
        return finishedEntry
    }
}