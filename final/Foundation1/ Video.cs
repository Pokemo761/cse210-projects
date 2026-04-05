using System;
using System.Collections.Generic;

// This class represents a YouTube video
// It stores information about the video and all its comments
public class Video
{
    // Private member variables (encapsulation)
    private string _title;      // The video title
    private string _author;     // The channel/author name
    private int _length;        // Length in seconds
    private List<Comment> _comments;  // List of all comments

    // Constructor - creates a new video
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();  // Start with empty comment list
    }

    // Add a comment to this video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Get the number of comments (demonstrates abstraction)
    // User doesn't need to know we're using a List - they just get the count
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Display all information about this video
    public void DisplayVideoInfo()
    {
        Console.WriteLine("─────────────────────────────────────────");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds ({_length / 60} minutes)");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("\nComments:");
        
        // Display each comment
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        
        Console.WriteLine("─────────────────────────────────────────\n");
    }
}