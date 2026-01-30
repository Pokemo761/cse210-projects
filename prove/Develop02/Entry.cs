using System;

// This class stores one journal entry
// I added extra stuff to make it better
// Now it also counts how many words I wrote
public class Entry
{
    // These variables remember the important parts of each entry
    public string _date;      // When the entry was written
    public string _prompt;    // The question that was asked
    public string _response;  // What the person wrote

    // This makes a new entry when someone writes in the journal
    // It needs the question (prompt) and what they wrote (response)
    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToShortDateString();  // Get today's date automatically
        _prompt = prompt;    // Save the question
        _response = response;  // Save what they wrote
    }

    // This shows the entry on the screen so we can read it
    public void Display()
    {
        // Show the date and the question
        Console.WriteLine($"{_date} - {_prompt}");
        
        // Show what the person wrote
        Console.WriteLine(_response);

        // This counts how many words I wrote by splitting the text at spaces
        int wordCount = _response.Split(" ").Length;
        Console.WriteLine($"Words written: {wordCount}");  // Show the word count

        Console.WriteLine();  // Add a blank line to make it easier to read
    }

    // This turns the entry into one line of text so we can save it to a file
    // We use the | symbol to separate the date, question, and answer
    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }
}