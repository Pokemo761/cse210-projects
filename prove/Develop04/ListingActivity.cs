using System;
using System.Collections.Generic;

// This class helps people list good things in their life
// It's like making a list of things you're thankful for
public class ListingActivity : Activity
{
    // These are the questions that help people think of things to list
    private List<string> _prompts;
    
    // This counts how many things they list
    private int _count;

    // This sets up the listing activity when we make a new one
    public ListingActivity()
    {
        // Tell it what kind of activity this is
        _name = "Listing";
        
        // Explain what this activity does
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        // Make a list and fill it with questions
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        // Start the count at zero
        _count = 0;
    }

    // This picks a random question from our list
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);  // Pick a random number
        return _prompts[index];  // Give back the question at that spot
    }

    // This lets the user type in their list and counts the items
    public List<string> GetListFromUser()
    {
        // Make an empty list to store what they type
        List<string> items = new List<string>();

        // Keep track of when to stop asking
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Keep asking them to type things until time is up
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();  // Get what they typed
            
            // Only count it if they actually typed something
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);  // Add it to our list
                _count++;  // Add one to our count
            }
        }

        // Give back the list of things they typed
        return items;
    }

    // This is what happens when you do the listing activity
    public override void Run()
    {
        // Show the starting message and ask how long they want to do it
        DisplayStartingMessage();

        // Show them a random question
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);  // Give them 5 seconds to get ready
        Console.WriteLine();

        // Let them start typing their list
        GetListFromUser();

        // Tell them how many things they listed
        Console.WriteLine($"\nYou listed {_count} items!");

        // Show the ending message to say they did a good job
        DisplayEndingMessage();
    }
}