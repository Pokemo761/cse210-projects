using System;

// DERIVED CLASS - Lecture event
// Inherits from Event and adds speaker and capacity
public class Lecture : Event
{
    // Additional attributes specific to lectures
    private string _speaker;
    private int _capacity;

    // Constructor - calls base constructor
    public Lecture(string title, string description, string date, string time, 
                   Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Override to add lecture-specific details
    public override string GetFullDetails()
    {
        return $"Type: Lecture\n" +
               $"{base.GetStandardDetails()}\n" +
               $"Speaker: {_speaker}\n" +
               $"Capacity: {_capacity}";
    }

    // Override to add event type
    public override string GetShortDescription()
    {
        return $"Lecture: {_title} on {_date}";
    }
}