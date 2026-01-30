using System;
using System.Collections.Generic;

// This class gives random prompts (questions) to ask people
// It's like a question jar where you pick a random slip of paper
public class PromptGenerator
{
    // This is our list of questions we can ask
    // We keep it private so only this class can see it
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    // This gives one random prompt from our list
    // It's like reaching into the jar and picking one question
    public string GetRandomPrompt()
    {
        // Make a random number picker
        Random rand = new Random();
        
        // Pick a random number between 0 and how many prompts we have
        // (If we have 5 prompts, it picks between 0 and 4)
        int index = rand.Next(_prompts.Count);
        
        // Give back the prompt at that random spot in the list
        return _prompts[index];
    }
}