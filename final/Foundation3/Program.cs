using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("═══════════════════════════════════════════");
        Console.WriteLine("    EVENT PLANNING MARKETING SYSTEM");
        Console.WriteLine("═══════════════════════════════════════════\n");

        // Create Event 1 - Lecture
        Address address1 = new Address("BYU-I Center", "Rexburg", "Idaho", "USA");
        Lecture lecture = new Lecture(
            "The Future of AI in Education",
            "Join us for an insightful discussion on how AI is transforming learning.",
            "March 15, 2026",
            "7:00 PM",
            address1,
            "Dr. Sarah Johnson",
            100
        );

        // Create Event 2 - Reception
        Address address2 = new Address("Grand Ballroom", "Salt Lake City", "Utah", "USA");
        Reception reception = new Reception(
            "Annual Charity Gala",
            "A fundraising event to support local education initiatives.",
            "April 20, 2026",
            "6:30 PM",
            address2,
            "rsvp@charitygala.org"
        );

        // Create Event 3 - Outdoor Gathering
        Address address3 = new Address("City Park", "Rexburg", "Idaho", "USA");
        OutdoorGathering outdoor = new OutdoorGathering(
            "Summer Music Festival",
            "Enjoy live music, food trucks, and family activities!",
            "June 10, 2026",
            "2:00 PM",
            address3,
            "Sunny, 75°F - Perfect weather!"
        );

        // Store all events in a list
        List<Event> events = new List<Event> { lecture, reception, outdoor };

        // Display marketing messages for each event
        foreach (Event ev in events)
        {
            Console.WriteLine("─────────────────────────────────────────");
            Console.WriteLine("STANDARD DETAILS:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("FULL DETAILS:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("SHORT DESCRIPTION:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("─────────────────────────────────────────\n");
        }

        Console.WriteLine("Program complete! All event marketing messages generated.");
    }
}