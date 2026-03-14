using System;

// This class is for goals you need to do multiple times
// Like "Go to the gym 10 times" - you get points each time, plus a bonus when done
public class ChecklistGoal : Goal
{
    // How many times you've done it so far
    private int _amountCompleted;
    
    // How many times you need to do it to finish
    private int _target;
    
    // Extra bonus points when you finish all of them
    private int _bonus;

    // Constructor for making a new checklist goal
    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;  // Start at zero
        _target = target;
        _bonus = bonus;
    }

    // Constructor for loading from a file
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) 
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    // This happens when you do the goal one more time
    public override int RecordEvent()
    {
        // Add one to the count
        _amountCompleted++;
        
        // If you just finished all of them, give bonus points!
        if (_amountCompleted >= _target)
        {
            return _points + _bonus;  // Regular points PLUS bonus!
        }
        else
        {
            return _points;  // Just regular points
        }
    }

    // This checks if you've done it enough times
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // This shows how many times you've done it
    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    // This creates a string to save to a file
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}