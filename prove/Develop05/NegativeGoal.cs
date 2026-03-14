using System;

// This class is for bad habits we want to stop
// When we do the bad habit, we LOSE points to help us remember not to do it
public class NegativeGoal : Goal
{
    // Constructor for making a new negative goal
    // The points should be negative (like -50)
    public NegativeGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        // Make sure points are negative
        if (_points > 0)
        {
            _points = -_points;  // Turn positive into negative
        }
    }

    // This happens when you did the bad habit
    public override int RecordEvent()
    {
        // Return negative points (you lose points!)
        return _points;
    }

    // Negative goals are never "complete" - we always have to fight bad habits
    public override bool IsComplete()
    {
        return false;
    }

    // Show it with a warning symbol to remind us it's a bad habit
    public override string GetDetailsString()
    {
        return $"[ ] ⚠️  {_shortName} ({_description})";
    }

    // This creates a string to save to a file
    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_shortName},{_description},{_points}";
    }
}