using System;

public class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        List<Event> events = program.CreateEvents();

        Console.Clear();
        string divider = new string('=', 20);

        Console.WriteLine(divider);
        events[0].StandardDetails();
        Console.WriteLine(divider);

        events[1].FullDetails();
        Console.WriteLine(divider);
        
        events[2].ShortDescription();
        Console.WriteLine(divider);
    }

    private List<Event> CreateEvents()
    {
        List<Event> events = new List<Event>();
        Lecture lecture = new Lecture(
            "Teacher Convention", 
            "01/01/2024", 
            "07:00pm", 
            "A lecture about how to become a more caring teachers", 
            new Address("32nd Street", "Toronto", "Ontario", "Canada"), 
            "Jake Nacho", 
            250);

        Reception reception = new Reception(
            "John and Susie's Wedding Reception", 
            "02/14/2024", 
            "5:00pm - 8:30pm", 
            "Come join us!", 
            new Address("Park Ave", "New York City", "New York", "USA"), 
            "john&susie2024@gmail.com");

        Outdoor outdoor = new Outdoor(
            "Memorial Day Gathering", 
            "05/24/2023", 
            "2:00pm", 
            "A Barbeque and Kickball Tournament", 
            new Address("Ridge Crest Dr", "Springville", "Utah", "USA"), 
            "Clear");
        
        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoor);
        return events;
    }
}