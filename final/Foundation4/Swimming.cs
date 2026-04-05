using System;

// DERIVED CLASS - Swimming activity
// Stores number of laps
public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    // Override - calculate distance from laps
    // Each lap is 50 meters = 0.05 km
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0; // Convert meters to kilometers
    }

    // Override summary to show activity type
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_minutes} min) - Distance: {GetDistance():F1} km, " +
               $"Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}