using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video(
            "Learn C# in 30 Minutes",
            "Code Academy",
            1800);

        video1.AddComment(new Comment("Gloria", "Excellent tutorial!"));
        video1.AddComment(new Comment("John", "Very easy to follow."));
        video1.AddComment(new Comment("Sarah", "Helped me finish my assignment."));
        video1.AddComment(new Comment("David", "Looking forward to Part 2."));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video(
            "Object-Oriented Programming Explained",
            "Programming Hub",
            1500);

        video2.AddComment(new Comment("Mike", "Best explanation ever."));
        video2.AddComment(new Comment("Grace", "Very informative."));
        video2.AddComment(new Comment("Peter", "Encapsulation finally makes sense."));
        video2.AddComment(new Comment("Ella", "Thank you!"));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video(
            "HTML & CSS Crash Course",
            "Web Dev Simplified",
            2400);

        video3.AddComment(new Comment("Alex", "Awesome content."));
        video3.AddComment(new Comment("Joy", "Loved the examples."));
        video3.AddComment(new Comment("Daniel", "Very practical."));
        video3.AddComment(new Comment("Sophia", "Great teacher."));

        videos.Add(video3);

        // Video 4
        Video video4 = new Video(
            "Introduction to GitHub",
            "Tech World",
            1200);

        video4.AddComment(new Comment("James", "Now I understand Git."));
        video4.AddComment(new Comment("Linda", "Simple explanation."));
        video4.AddComment(new Comment("Chris", "Perfect for beginners."));
        video4.AddComment(new Comment("Angela", "Subscribed!"));

        videos.Add(video4);

        // Display all videos

        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("\nComments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}