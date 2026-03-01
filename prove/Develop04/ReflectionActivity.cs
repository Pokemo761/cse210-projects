using System;
using System.Collections.Generic;

// This class helps people think about times when they were strong or brave
// It asks them questions to help them think deeply
public class ReflectionActivity : Activity
{
    // These are the starter questions that make people remember something good
    private List<string> _prompts;
    
    // These are the follow-up questions that help them think more about it
    private List<string> _questions;

    // This sets up the reflection activity when we make a new one
    public ReflectionActivity()
    {
        // Tell it what kind of activity this is
        _name = "Reflection";
        
        // Explain what this activity does
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        // Make a list and fill it with starter questions
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Make a list and fill it with thinking questions
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // This picks a random starter question from our list
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);  // Pick a random number
        return _prompts[index];  // Give back the question at that spot
    }

    // This picks a random thinking question from our list
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);  // Pick a random number
        return _questions[index];  // Give back the question at that spot
    }

    // This is what happens when you do the reflection activity
    public override void Run()
    {
        // Show the starting message and ask how long they want to do it
        DisplayStartingMessage();

        // Show them a random starter question
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();  // Wait for them to press enter

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);  // Give them 5 seconds to get ready
        Console.Clear();

        // Keep track of how much time has passed
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Keep asking questions until time is up
        while (DateTime.Now < endTime)
        {
            // Show a random thinking question
            Console.Write($"> {GetRandomQuestion()} ");
            
            // Show the spinner while they think (give them time to ponder)
            ShowSpinner(10);
            Console.WriteLine();
        }

        // Show the ending message to say they did a good job
        DisplayEndingMessage();
    }
}