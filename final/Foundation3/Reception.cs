using System;

// DERIVED CLASS - Reception event
// Inherits from Event and adds RSVP email
public class Reception : Event
{
    // Additional attribute specific to receptions
    private string _rsvpEmail;

    // Constructor - calls base constructor
    public Reception(string title, string description, string date, string time,
                     Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    // Override to add reception-specific details
    public override string GetFullDetails()
    {
        return $"Type: Reception\n" +
               $"{base.GetStandardDetails()}\n" +
               $"RSVP Email: {_rsvpEmail}";
    }

    // Override to add event type
    public override string GetShortDescription()
    {
        return $"Reception: {_title} on {_date}";
    }
}