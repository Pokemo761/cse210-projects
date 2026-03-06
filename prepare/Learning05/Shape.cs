using System;

// This is the parent class for all shapes
// It's like a template that says "all shapes have a color and an area"
public class Shape
{
    // This remembers what color the shape is
    private string _color;

    // This is how we make a new shape and tell it what color it is
    public Shape(string color)
    {
        _color = color;
    }

    // This lets us see what color the shape is
    public string GetColor()
    {
        return _color;
    }

    // This lets us change the color if we want to
    public void SetColor(string color)
    {
        _color = color;
    }

    // This calculates the area (how much space the shape takes up)
    // The word "virtual" means each shape can have its own special way to calculate area
    // We put 0 here because the parent class doesn't know how big it is yet
    public virtual double GetArea()
    {
        return 0;
    }
}