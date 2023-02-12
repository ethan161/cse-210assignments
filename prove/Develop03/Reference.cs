using System;

class Reference
{
    public Reference(string book, int chapter, string verses) 
    {
        Book = book;
        Chapter = chapter;
        Verses = verses;
    }
    public string Book { get; set; }
    public int Chapter { get; set; }
    public string Verses { get; set; }

    public void Display() 
    {
        Console.Write($"{Book} {Chapter}:{Verses} ");
    }
}

