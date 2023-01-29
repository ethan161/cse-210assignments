using System;

public class Entry
{

    public string[] _localEntries = {};
    
    public void saveToComputer()
    {
        
    }
    public void saveToFile(){
        string file = "textfile.txt";
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine();
        }
    }
    public string[] readFile()
    {
        string filename = "textfile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
        }
        return lines;
    }
}