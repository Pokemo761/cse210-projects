using System;

// DERIVED CLASS - Cycling activity
// Stores speed directly
public class Cycling : Activity
{
    private double _speed; // in kph

    public Cycling(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    // Override - calculate distance from speed
    public override double GetDistance()
    {
        return (_speed * _minutes) / 60;
    }

    // Override - return stored speed
    public override double GetSpeed()
    {
        return _speed;
    }

    // Override summary to show activity type
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_minutes} min) - Distance: {GetDistance():F1} km, " +
               $"Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}