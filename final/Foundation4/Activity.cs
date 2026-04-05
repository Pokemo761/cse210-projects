using System;

// BASE CLASS for all activities
// Contains common attributes and virtual methods
public class Activity
{
    // Protected so derived classes can access
    protected string _date;
    protected int _minutes;

    // Constructor
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // VIRTUAL methods - will be overridden by derived classes
    // Each activity calculates these differently (POLYMORPHISM!)
    public virtual double GetDistance()
    {
        return 0; // Base implementation
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public virtual double GetPace()
    {
        return _minutes / GetDistance();
    }

    // Get summary - uses the other methods
    // This works for ALL activities because of polymorphism!
    public virtual string GetSummary()
    {
        return $"{_date} ({_minutes} min) - Distance: {GetDistance():F1} km, " +
               $"Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}