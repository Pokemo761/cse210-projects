using System;

// This class represents a comment on a YouTube video
public class Comment
{
    // Private member variables
    private string _commenterName;  // Who made the comment
    private string _commentText;    // What they said

    // Constructor - creates a new comment
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Get the commenter's name
    public string GetCommenterName()
    {
        return _commenterName;
    }

    // Get the comment text
    public string GetCommentText()
    {
        return _commentText;
    }

    // Display this comment in a nice format
    public void DisplayComment()
    {
        Console.WriteLine($"  • {_commenterName}: \"{_commentText}\"");
    }
}