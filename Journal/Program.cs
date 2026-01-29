using System;

// EXCEEDING REQUIREMENTS:
// I added a word counter to each journal entry.
// It shows how many words the user wrote.
// This helps people see how much they are writing.

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = prompts.GetRandomPrompt();
                    Console.WriteLine(prompt);

                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry(prompt, response);
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Filename: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Filename: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
            }
        }
    }
}
