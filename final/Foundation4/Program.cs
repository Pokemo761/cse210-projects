using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("═══════════════════════════════════════════");
        Console.WriteLine("    FITNESS CENTER EXERCISE TRACKER");
        Console.WriteLine("═══════════════════════════════════════════\n");

        // Create a list to hold all activities
        // Notice: List<Activity> can hold ANY derived class!
        List<Activity> activities = new List<Activity>();

        // Create different types of activities
        Running running = new Running("03 Nov 2022", 30, 4.8);
        Cycling cycling = new Cycling("04 Nov 2022", 45, 20.0);
        Swimming swimming = new Swimming("05 Nov 2022", 30, 20);

        // Add to list
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Display summaries - THIS IS POLYMORPHISM IN ACTION!
        // We call GetSummary() on each Activity, but the correct
        // version runs based on the actual object type!
        Console.WriteLine("EXERCISE SUMMARIES:\n");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine("\n─────────────────────────────────────────");
        Console.WriteLine("Program complete! All activities tracked.");
    }
}
