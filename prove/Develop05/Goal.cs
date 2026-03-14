using System;

// This is the parent class for all types of goals
// It holds the things that ALL goals have in common
public class Goal
{
    // These are protected so child classes can use them
    protected string _shortName;  // The name of the goal
    protected string _description;  // What the goal is about
    protected int _points;  // How many points you get

    // Constructor - this sets up a new goal
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // This records when you complete the goal
    // Each type of goal does this differently, so we use "virtual"
    public virtual int RecordEvent()
    {
        return _points;
    }

    // This checks if the goal is finished
    // Each type of goal decides this differently
    public virtual bool IsComplete()
    {
        return false;
    }

    // This shows the goal details when listing all goals
    public virtual string GetDetailsString()
    {
        // Put [X] if complete, [ ] if not complete
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description})";
    }

    // This creates a string to save the goal to a file
    public virtual string GetStringRepresentation()
    {
        return $"Goal:{_shortName},{_description},{_points}";
    }

    // This lets us see the goal name
    public string GetShortName()
    {
        return _shortName;
    }

    // This lets us see how many points the goal is worth
    public int GetPoints()
    {
        return _points;
    }
}