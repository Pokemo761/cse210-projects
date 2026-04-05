using System;

// BASE CLASS for all events
// Contains common attributes and behaviors shared by all event types
public class Event
{
    // Protected so derived classes can access them
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    // Constructor
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Standard details - shows basic info (all events use this)
    public string GetStandardDetails()
    {
        return $"Title: {_title}\n" +
               $"Description: {_description}\n" +
               $"Date: {_date}\n" +
               $"Time: {_time}\n" +
               $"Address: {_address.GetFullAddress()}";
    }

    // Full details - VIRTUAL so derived classes can override
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    // Short description - VIRTUAL so derived classes can override
    public virtual string GetShortDescription()
    {
        return $"Event: {_title} on {_date}";
    }
}