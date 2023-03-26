using System;

public class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        List<Video> videos = program.CreateVideos();
        program.Display(videos);
    }

    private void Display(List<Video> videos)
    {
        foreach (Video newVideo in videos)
        {
            Console.WriteLine();
            Console.WriteLine($"'{newVideo.Title}' by {newVideo.Author} ({newVideo.Length/60}:{newVideo.Length%60})");
            Console.WriteLine($"{newVideo.NumberOfComments()} comments: ");
            foreach (Comment comment in newVideo.Comments)
            {
                Console.WriteLine($"{comment.Author}: {comment.Text}");
            }
        }
    }

    private List<Video> CreateVideos()
    {
        Video video1 = new Video("How to Make a Pancake", "Joe34", 145);
        video1.Comments.Add(new Comment("John", "Nice video!"));
        video1.Comments.Add(new Comment("Susie", "When is your next video?"));
        video1.Comments.Add(new Comment("Bill", "Very cool demonstration."));

        Video video2 = new Video("Swapping a Tire", "Mechanic21", 1513);
        video2.Comments.Add(new Comment("Kim", "Thanks for the video!"));
        video2.Comments.Add(new Comment("Susan", "Does this work on a truck?"));
        video2.Comments.Add(new Comment("William", "Very good job."));

        Video video3 = new Video("Playing my New Game", "Gamer201", 1002);
        video3.Comments.Add(new Comment("Paul", "Thanks for the gameplay!"));
        video3.Comments.Add(new Comment("Julie", "Does this work on an Xbox?"));
        video3.Comments.Add(new Comment("Davis", "You should play this again!"));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        return videos;
    }
}