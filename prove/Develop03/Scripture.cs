using System; // My using statemtns
using System.Collections.Generic;

public class Scripture
{
    // private fields
    // _words code words are hidden 
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _rand = new Random();

    // Create new scripture
    public Scripture(Reference reference, string text)
    {
        _reference = reference; // _reference = reference


        string[] parts = text.Split(" "); // break my sentence into individual words
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int count) // hide random words
    {
        int hidden = 0;

        while (hidden < count)
        {
            int index = _rand.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }
        }
    }

    public bool AllHidden()
    {
        // loop each words a create word object
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return text;
    }
}