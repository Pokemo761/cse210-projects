using System;

// DERIVED CLASS - Running activity
// Stores distance directly
public class Running : Activity
{
    private double _distance; // in kilometers

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    // Override - return stored distance
    public override double GetDistance()
    {
        return _distance;
    }

    // Override summary to show activity type
    public override string GetSummary()
    {
        return $"{_date} Running ({_minutes} min) - Distance: {GetDistance():F1} km, " +
               $"Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}