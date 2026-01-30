using System;
using System.Collections.Generic;
using System.IO;

// This class holds all the journal entries
// It's like a notebook that keeps track of everything you've written
public class Journal
{
    // This is our list that holds all the entries
    // It starts empty and we add entries to it as people write
    public List<Entry> _entries = new List<Entry>();

    // This adds a new entry to our list
    // It's like adding a new page to your notebook
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);  // Put the new entry at the end of our list
    }

    // This shows all entries on the screen
    // It goes through each entry one by one and displays it
    public void DisplayAll()
    {
        // Look at each entry in our list
        foreach (Entry entry in _entries)
        {
            entry.Display();  // Tell that entry to show itself
        }
    }

    // This saves the journal to a file on the computer
    // So you can close the program and come back later
    public void SaveToFile(string filename)
    {
        // Open a file to write in (the 'using' makes sure it closes when we're done)
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Go through each entry in our journal
            foreach (Entry entry in _entries)
            {
                // Turn the entry into one line of text and write it to the file
                writer.WriteLine(entry.ToFileString());
            }
        }
        // The file automatically closes here!
    }

    // This loads the journal from a file
    // It reads what you saved before and puts it back in the journal
    public void LoadFromFile(string filename)
    {
        // Throw away any entries we have now (we're replacing them)
        _entries.Clear();

        // Read all the lines from the file into a list
        string[] lines = File.ReadAllLines(filename);

        // Go through each line we read from the file
        foreach (string line in lines)
        {
            // Split the line into pieces using the | symbol
            // parts[0] = date, parts[1] = prompt, parts[2] = response
            string[] parts = line.Split("|");

            // Make a new entry from the pieces we found
            Entry entry = new Entry(parts[1], parts[2]);
            
            // Set the date from the file (not today's date)
            entry._date = parts[0];

            // Add this entry to our journal
            _entries.Add(entry);
        }
    }
}