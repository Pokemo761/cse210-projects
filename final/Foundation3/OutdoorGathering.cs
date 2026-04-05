using System;

// DERIVED CLASS - Outdoor Gathering event
// Inherits from Event and adds weather forecast
public class OutdoorGathering : Event
{
    // Additional attribute specific to outdoor events
    private string _weatherForecast;

    // Constructor - calls base constructor
    public OutdoorGathering(string title, string description, string date, string time,
                            Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    // Override to add outdoor-specific details
    public override string GetFullDetails()
    {
        return $"Type: Outdoor Gathering\n" +
               $"{base.GetStandardDetails()}\n" +
               $"Weather Forecast: {_weatherForecast}";
    }

    // Override to add event type
    public override string GetShortDescription()
    {
        return $"Outdoor Gathering: {_title} on {_date}";
    }
}