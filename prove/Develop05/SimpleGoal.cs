using System;

// This class is for goals you only do once
// Like "Finish reading a book" - you do it once and you're done
public class SimpleGoal : Goal
{
    // This remembers if we finished the goal or not
    private bool _isComplete;

    // Constructor for making a new simple goal
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        // When we first make the goal, it's not done yet
        _isComplete = false;
    }

    // Constructor for loading a goal from a file
    public SimpleGoal(string name, string description, int points, bool isComplete) 
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // This happens when you complete the goal
    public override int RecordEvent()
    {
        // Mark it as complete
        _isComplete = true;
        // Give back the points you earned
        return _points;
    }

    // This checks if the goal is done
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // This creates a string to save to a file
    public override string GetStringRepresentation()
    {
        // Save it like: SimpleGoal:name,description,points,true
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}