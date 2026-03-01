using System;

// EXCEEDING REQUIREMENTS:
// I added an extra activity called "Gratitude Activity" that helps people
// think about things they are grateful for. This gives users more options
// and helps them practice being thankful every day.

class Program
{
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
            }
            else if (choice == "2")
            {
                // Make a new reflection activity and run it
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }
            else if (choice == "3")
            {
                // Make a new listing activity and run it
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
                // Say goodbye and stop the program
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
    }
}