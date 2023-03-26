using System;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Display();
    }

    public void Display()
    {
        Video newVideo = CreateVideo();
        Console.WriteLine($"'{newVideo[0]}' by {newVideo[1]} ({newVideo[2]/60}:{newVideo[2]%60})");
        Console.WriteLine($"Comments: ({.NumberOfComments()})");
        foreach (string comment in comments)
        {
            Console.WriteLine($"{comment}")
        }
    }

    public List<Comment> CreateComments()
    {
        List<Comment> comments = new List<Comment>();
        comments.Add(new Comment("John", "Nice video!"));
        comments.Add(new Comment("Susie", "When is your next video?"));
        comments.Add(new Comment("Bill", "Very cool demonstration."));
        return comments;
    }

    public Video CreateVideo()
    {
        Video newVideo = new Video("How to Make a Pancake", "Joe34", 145);
        CreateComment();
        return newVideo;
    }

}