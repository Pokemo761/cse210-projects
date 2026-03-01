using System;

// This class helps people breathe slowly and calmly
// It's like when your teacher tells you to take deep breaths
public class BreathingActivity : Activity
{
    // This sets up the breathing activity when we make a new one
    public BreathingActivity()
    {
        // Tell it what kind of activity this is
        _name = "Breathing";
        
        // Explain what this activity does
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // This is what happens when you do the breathing activity
    public override void Run()
    {
        // Show the starting message and ask how long they want to do it
        DisplayStartingMessage();

        // Keep track of how much time has passed
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Keep going until the time is up
        while (DateTime.Now < endTime)
        {
            // Tell them to breathe in
            Console.Write("\nBreathe in...");
            ShowCountDown(4);  // Count down from 4 while they breathe in
            Console.WriteLine();

            // Tell them to breathe out
            Console.Write("Now breathe out...");
            ShowCountDown(6);  // Count down from 6 while they breathe out
            Console.WriteLine();
        }

        // Show the ending message to say they did a good job
        DisplayEndingMessage();
    }
}