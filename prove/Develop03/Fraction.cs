using System;

// This class represents a fraction like 3/4
public class Fraction
{
    // These store the top and bottom numbers
    // They are private so other classes cannot change them directly
    private int _top;
    private int _bottom;

    // Default constructor
    // Makes the fraction 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one number
    // The bottom is set to 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Gets the top number
    public int GetTop()
    {
        return _top;
    }

    // Sets the top number
    public void SetTop(int top)
    {
        _top = top;
    }

    // Gets the bottom number
    public int GetBottom()
    {
        return _bottom;
    }

    // Sets the bottom number
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns the fraction as a string like "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
