using System;

class Scripture
{
    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();
        foreach (string word in text.Split(" "))
        {
            Words.Add(new Word(word, false));
        }
    }

    public Reference Reference { get; set; }

    public List<Word> Words { get; set; }

    public void Display()
    {
        Console.Clear();
        Reference.Display();
        foreach (Word word in Words)
        {
            Console.Write($"{word} ");
        }
    }

    public void HideWord(int index)
    {
        Words[index].IsHidden = true;
    }

    public bool AreAllHidden()
    {
        foreach (Word word in Words)
        {
            if (!word.IsHidden) 
            {
                return false;
            }
        }
        
        return true;
    }

    public List<int> GetVisibleWordIndexes()
    {
        List<int> visibleWords = new List<int>(); 
        for (int i = 0; i < Words.Count; i++)
        {
            if(!Words[i].IsHidden)
            {
                visibleWords.Add(i);
            }
        }

        return visibleWords;
    }

    public int WordCount
    {
        get
        {
            return Words.Count;
        }
    }
}