using System;

// EXCEEDING REQUIREMENTS:
// 1. Added a session counter that tracks how many activities the user completes
//    in one program session. This helps users see their progress and stay motivated.
//
// 2. Added enhanced breathing animation that shows growing/shrinking text to
//    visually represent the breath expanding and contracting, making the exercise
//    more immersive and effective.
//
// 3. Implemented "smart prompts" in ReflectionActivity - the program now ensures
//    no prompt or question is repeated until all have been shown at least once.
//    This provides a better user experience and more variety in each session.
//
// 4. Added a summary at the end of each session showing total time spent in
//    mindfulness activities, encouraging users to track their wellness journey.

class Program
{
    // This counts how many activities they've completed this session
    private static int _sessionCount = 0;
    
    // This tracks total time spent in activities
    private static int _totalTime = 0;

    static void Main(string[] args)
    {
        // This keeps the program running until they want to quit
        bool running = true;

        // Keep showing the menu until they pick "Quit"
        while (running)
        {
            // Show the menu options
            DisplayMenu();

            // Get what number they typed
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            // Do different things based on what they picked
            if (choice == "1")
            {
                // Make a new breathing activity and run it
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                _sessionCount++;  // Add one to our count
                _totalTime += breathing.GetDuration();  // Add the time
            }
            else if (choice == "2")
            {
                // Make a new reflection activity and run it
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                _sessionCount++;  // Add one to our count
                _totalTime += reflection.GetDuration();  // Add the time
            }
            else if (choice == "3")
            {
                // Make a new listing activity and run it
                ListingActivity listing = new ListingActivity();
                listing.Run();
                _sessionCount++;  // Add one to our count
                _totalTime += listing.GetDuration();  // Add the time
            }
            else if (choice == "4")
            {
                // Show them their session summary before quitting
                Console.Clear();
                Console.WriteLine("=== Session Summary ===");
                Console.WriteLine($"Activities completed: {_sessionCount}");
                Console.WriteLine($"Total time in mindfulness: {_totalTime} seconds");
                Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                running = false;  // This stops the loop
            }
            else
            {
                // If they typed something wrong, tell them to try again
                Console.WriteLine("\nInvalid choice. Please try again.");
            }
        }
    }

    // This shows the menu with all the choices
    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.WriteLine($"\nActivities completed this session: {_sessionCount}");
    }
}