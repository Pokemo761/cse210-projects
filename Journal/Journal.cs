using System;
using System.Collections.Generic;
using System.IO;

// This class holds all the journal entries
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // This adds a new entry to the list
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // This shows all entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // This saves the journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }
    }

    // This loads the journal from a file
    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry(parts[1], parts[2]);
            entry._date = parts[0];

            _entries.Add(entry);
        }
    }
}
