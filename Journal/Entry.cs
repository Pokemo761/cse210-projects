using System;

// This class stores one journal entry
// I added extra stuff to make it better
// Now it also counts how many words I wrote
public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    // This makes a new entry
    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToShortDateString();
        _prompt = prompt;
        _response = response;
    }

    // This shows the entry on the screen
    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_response);

        // This counts how many words I wrote
        int wordCount = _response.Split(" ").Length;
        Console.WriteLine($"Words written: {wordCount}");

        Console.WriteLine();
    }

    // This turns the entry into text for a file
    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }
}
