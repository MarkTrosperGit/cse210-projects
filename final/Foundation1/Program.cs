using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        // List<Video> videoList = new List<Video>();
        // List<Comment> list1 = new List<Comment>();
        // Comment person1 = new Comment("Mark", "Soo good!");
        // list1.Add(person1);
        // Comment person2 = new Comment("Caleb", "Oh, good!");
        // list1.Add(person2);
        // Comment person3 = new Comment("Jess", "No way!");
        // list1.Add(person3);
        // Comment person4 = new Comment("Gorilla", "What's that guy in the back doing!");
        // list1.Add(person4);
        // Video Video4 = new Video("Crazy Teacher Person", "Mark Trosper", 15, list1);

        List<Comment> list1 = new List<Comment>
        {
            new Comment("Mark", "Soo good!"),
            new Comment("Caleb", "Oh, good!"),
            new Comment("Jess", "No way!"),
            new Comment("Gorilla", "What's that guy in the back doing!")
        };
        List<Comment> list2 = new List<Comment>
        {
            new Comment("Micahel", "Oof!"),
            new Comment("Matt", "Naw man!"),
            new Comment("Troy", "Yolo!"),
            new Comment("Bruh", "Duh!")
        };
        List<Comment> list3 = new List<Comment>
        {
            new Comment("Sara", "yo.!"),
            new Comment("Sam", "Yessir!"),
            new Comment("Samantha", "Cute!"),
            new Comment("Sappy S", "You're the best!")
        };
        List<Comment> list4 = new List<Comment>
        {
            new Comment("Nathan", "No!"),
            new Comment("Nora", "Still, strawberry"),
            new Comment("Nappy", "Potato!"),
            new Comment("Sweat", "yams!")
        };
        List<Video> videoList = new List<Video>
        {
            new Video("Crazy Teacher Person", "Mark Trosper", 15, list1),
            new Video("Look At My House", "Seth Trosper", 20, list2),
            new Video("Ah, He Did It!", "Micaehl Trosper", 25, list3),
            new Video("Veggies in Northern Brazil", "Aaron Trosper", 30, list4)
        };
        foreach (Video video in videoList)
        {
            video.DisplayVideoInfo();
            video.DisplayComments();
        }



    }
}