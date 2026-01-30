using System;

// EXCEEDING REQUIREMENTS:
// I added a word counter to each journal entry.
// It shows how many words the user wrote.
// This helps people see how much they are writing.

class Program
{
    static void Main()
    {
        // Make a new journal to store all our entries
        Journal journal = new Journal();
        
        // Make a new prompt generator to give us random questions
        PromptGenerator prompts = new PromptGenerator();

        // This remembers if the program should keep running
        bool running = true;

        // Keep showing the menu until the user wants to quit
        while (running)
        {
            // Show the menu with all the things you can do
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            // Get what the user typed
            string choice = Console.ReadLine();

            // Do different things based on what they picked
            switch (choice)
            {
                case "1":  // If they picked 1, write a new entry
                    // Get a random question to ask them
                    string prompt = prompts.GetRandomPrompt();
                    Console.WriteLine(prompt);  // Show them the question

                    // Get their answer
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    // Make a new entry with the question and their answer
                    Entry entry = new Entry(prompt, response);
                    
                    // Add this entry to the journal
                    journal.AddEntry(entry);
                    break;

                case "2":  // If they picked 2, show all entries
                    journal.DisplayAll();  // Show everything in the journal
                    break;

                case "3":  // If they picked 3, save to a file
                    Console.Write("Filename: ");  // Ask what to name the file
                    journal.SaveToFile(Console.ReadLine());  // Save it with that name
                    break;

                case "4":  // If they picked 4, load from a file
                    Console.Write("Filename: ");  // Ask which file to open
                    journal.LoadFromFile(Console.ReadLine());  // Load it
                    break;

                case "5":  // If they picked 5, quit the program
                    Console.WriteLine("Goodbye!");  // Say goodbye nicely
                    running = false;  // Stop the loop so the program ends
                    break;
            }
        }
        // When running becomes false, the loop stops and the program ends
    }
}