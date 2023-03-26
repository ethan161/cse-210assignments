using System;

public class Comment
{
    public string Author { get; init; }

    public string Text { get; init; }

    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }
}