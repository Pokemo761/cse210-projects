public class Word
{
    private string _text;
    private bool _hidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide() // this method hides the word
    {
        _hidden = true; // marks the word as hidden 
    }

    public bool IsHidden()
    {
        return _hidden; // returns whether the word is hiddne or not
    }

    public string GetDisplayText() // This controls what the user sees
    {
        if (_hidden)
            return new string('_', _text.Length); // Please check if any wor should be hidden
        else
            return _text; 
    }
} 