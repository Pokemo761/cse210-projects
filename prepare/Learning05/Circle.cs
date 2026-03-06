using System;

// This is a circle shape that inherits from Shape
// A circle is round, like a pizza or a coin
public class Circle : Shape
{
    // This remembers the radius (distance from center to edge)
    private double _radius;

    // This is how we make a new circle
    // We need to know the color and the radius
    public Circle(string color, double radius) : base(color)
    {
        // The ": base(color)" tells the parent Shape class what color to use
        
        // Remember the radius
        _radius = radius;
    }

    // This calculates the area of the circle
    // To find a circle's area, we use the formula: π × radius × radius
    // π (pi) is a special number that's about 3.14159
    public override double GetArea()
    {
        // Math.PI is the computer's way of knowing what pi is
        // If radius is 3, then area is 3.14159 × 3 × 3 = about 28.27
        return Math.PI * _radius * _radius;
    }
}