using System;

// This class is for goals that never finish
// Like "Practice guitar" - you can do it every day forever
public class EternalGoal : Goal
{
    // Constructor for making a new eternal goal
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        // Eternal goals don't need extra stuff, just the basics from Goal
    }

    // This happens every time you do the goal
    public override int RecordEvent()
    {
        // You get points every single time!
        return _points;
    }

    // Eternal goals are NEVER complete - you can always do them again
    public override bool IsComplete()
    {
        return false;  // Always false!
    }

    // This creates a string to save to a file
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}