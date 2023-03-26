using System;

public class Video
{
    public string Title { get; init; }

    public string Author { get; init; }

    public int Length { get; init; }

    public List<Comment> Comments { get; init; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public int NumberOfComments()
    {
        return Comments.Count;
    }
}