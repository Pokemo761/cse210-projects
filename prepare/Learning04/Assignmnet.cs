using System;

public class Assignment
{
    // Private fields
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Summary method
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Getter for derived classes
    public string GetStudentName()
    {
        return _studentName;
    }
}