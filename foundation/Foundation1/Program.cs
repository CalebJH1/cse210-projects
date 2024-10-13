using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Video videoA = new Video("Best day ever!", "Caleb", 300);
        Comment commentA1 = new Comment("Noah", "Awesome!");
        Comment commentA2 = new Comment("Art", "Looks like you had a lot of fun!");
        Comment commentA3 = new Comment("Jacob", "Hi!");
        
        videoA._comments.Add(commentA1);
        videoA._comments.Add(commentA2);
        videoA._comments.Add(commentA3);

        Video videoB = new Video("My big game!", "Noah", 3600);
        Comment commentB1 = new Comment("Caleb", "You're such a talented player!");
        Comment commentB2 = new Comment("Art", "I wish I could be there.");
        Comment commentB3 = new Comment("Anonymous", "Very cool! I used to play baseball when I was a kid. I really wanted to keep going, but sadly due to an injury, I couldn't keep playing:(");

        videoB._comments.Add(commentB1);
        videoB._comments.Add(commentB2);
        videoB._comments.Add(commentB3);

        Video videoC = new Video("My cooking stream.", "Art", 7200);
        Comment commentC1 = new Comment("Caleb", "I love watching you cook; it makes my day.");
        Comment commentC2 = new Comment("Anonymous", "What's up?");
        Comment commentC3 = new Comment("Jordan", "Nice! Cooking isn't that easy, and the more you do it, the better you'll get:)");
        Comment commentC4 = new Comment("Jacob", "Hey man!");

        videoC._comments.Add(commentC1);
        videoC._comments.Add(commentC2);
        videoC._comments.Add(commentC3);
        videoC._comments.Add(commentC4);

        List<Video> videoList = new List<Video>();
        videoList.Add(videoA);
        videoList.Add(videoB);
        videoList.Add(videoC);

        foreach (Video video in videoList)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"By: {video._author}");
            Console.WriteLine($"Length (in seconds): {video._length}");
            Console.WriteLine();
            Console.WriteLine($"{video.CountComments()} comments:");
            Console.WriteLine();
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine(comment._name);
                Console.WriteLine(comment._text);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}