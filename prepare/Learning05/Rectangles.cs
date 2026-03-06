using System;

// This is a rectangle shape that inherits from Shape
// A rectangle is like a stretched square - it has a long side and a short side
public class Rectangle : Shape
{
    // This remembers how long the rectangle is
    private double _length;
    
    // This remembers how wide (tall) the rectangle is
    private double _width;

    // This is how we make a new rectangle
    // We need to know the color, the length, and the width
    public Rectangle(string color, double length, double width) : base(color)
    {
        // The ": base(color)" tells the parent Shape class what color to use
        
        // Remember the length and width
        _length = length;
        _width = width;
    }

    // This calculates the area of the rectangle
    // To find a rectangle's area, we multiply length times width
    public override double GetArea()
    {
        // If length is 5 and width is 3, then area is 5 × 3 = 15
        return _length * _width;
    }
}