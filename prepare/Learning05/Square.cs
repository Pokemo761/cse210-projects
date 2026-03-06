using System;

// This is a square shape that inherits from Shape
// A square has 4 equal sides, like a piece of square paper
public class Square : Shape
{
    // This remembers how long one side of the square is
    private double _side;

    // This is how we make a new square
    // We need to know the color and how long the side is
    public Square(string color, double side) : base(color)
    {
        // Save the base class constructor (this sets the color)
        // The ": base(color)" part tells the parent Shape class what color to use
        
        // Remember how long the side is
        _side = side;
    }

    // This calculates the area of the square
    // To find a square's area, we multiply side times side (side × side)
    // The word "override" means we're replacing the parent's GetArea with our own version
    public override double GetArea()
    {
        // If the side is 4, then the area is 4 × 4 = 16
        return _side * _side;
    }
}