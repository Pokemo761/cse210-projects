using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("═══════════════════════════════════════════");
        Console.WriteLine("    YOUTUBE VIDEO TRACKING SYSTEM");
        Console.WriteLine("═══════════════════════════════════════════\n");

        // Create a list to store all videos
        List<Video> videos = new List<Video>();

        // Create Video 1 - C# Tutorial
        Video video1 = new Video("Learn C# in 30 Minutes", "Programming Tutorial Channel", 1800);
        video1.AddComment(new Comment("Sarah Johnson", "This helped me so much with my CSE 121C homework!"));
        video1.AddComment(new Comment("Mike Chen", "Great explanation of classes and objects."));
        video1.AddComment(new Comment("Emily Rodriguez", "Can you make a video about inheritance next?"));
        video1.AddComment(new Comment("David Park", "Best C# tutorial I've found!"));
        videos.Add(video1);

        // Create Video 2 - Guitar Tutorial
        Video video2 = new Video("Guitar Tutorial - Beginner Chords", "Music Masters", 480);
        video2.AddComment(new Comment("Tom Wilson", "Finally I can play my first song!"));
        video2.AddComment(new Comment("Lisa Park", "Very clear instructions, thank you!"));
        video2.AddComment(new Comment("David Kim", "The camera angle made it easy to follow."));
        videos.Add(video2);

        // Create Video 3 - Italian Lesson
        Video video3 = new Video("Italian Lesson 5 - Past Tense", "Learn Italian Fast", 720);
        video3.AddComment(new Comment("Carlos Santos", "Ho capito! Thanks for the examples."));
        video3.AddComment(new Comment("Rachel Green", "This is exactly what I needed for my test."));
        video3.AddComment(new Comment("Marco Rossi", "Ottimo video!"));
        video3.AddComment(new Comment("Anna Martinez", "Can you explain the irregular verbs?"));
        videos.Add(video3);

        // Create Video 4 - Gym Workout
        Video video4 = new Video("Full Body Workout - 45 Minutes", "Fitness Pro", 2700);
        video4.AddComment(new Comment("Jake Thompson", "That was intense! Great workout."));
        video4.AddComment(new Comment("Maria Garcia", "I'm so sore but in a good way!"));
        video4.AddComment(new Comment("Chris Lee", "Love the modifications for beginners."));
        videos.Add(video4);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }

        Console.WriteLine("\nProgram complete! All videos displayed.");
    }
}