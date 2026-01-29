// You need to use this link to create the imagine
// https://www.plantuml.com/plantuml/uml/SoWkIImgAStDuNBAJrBGjLDmpCbCJbMmKiX8pSd9vt98pKi1IW80

using System;
prompts.GetRandomPrompt();

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

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = prompts.GetRandomPrompt();
                    Console.WriteLine(prompt);
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
                    running = false;
                    break;
            }
        }
    }
}
