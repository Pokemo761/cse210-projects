using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // First, let's test each shape one at a time to make sure they work
        
        Console.WriteLine("=== Testing Individual Shapes ===\n");
        
        // Make a red square with sides that are 4 units long
        Square square = new Square("Red", 4);
        Console.WriteLine($"Square Color: {square.GetColor()}");
        Console.WriteLine($"Square Area: {square.GetArea()}\n");
        
        // Make a blue rectangle that's 5 units long and 3 units wide
        Rectangle rectangle = new Rectangle("Blue", 5, 3);
        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}\n");
        
        // Make a green circle with a radius of 3 units
        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"Circle Color: {circle.GetColor()}");
        Console.WriteLine($"Circle Area: {circle.GetArea()}\n");
        
        
        // Now let's put all the shapes in one list!
        // This is the cool part - we can store different shapes in the same list!
        // The list holds "Shape" objects, which means it can hold ANY shape
        // (square, rectangle, circle, or any other shape we make later)
        
        Console.WriteLine("=== All Shapes in a List ===\n");
        
        // Make an empty list to hold our shapes
        List<Shape> shapes = new List<Shape>();
        
        // Add different shapes to our list
        shapes.Add(new Square("Yellow", 6));        // Add a yellow square
        shapes.Add(new Rectangle("Purple", 8, 4));  // Add a purple rectangle
        shapes.Add(new Circle("Orange", 5));        // Add an orange circle
        shapes.Add(new Square("Pink", 3));          // Add a pink square
        
        // Go through each shape in our list
        // Even though they're different types (square, rectangle, circle),
        // we can treat them all the same way!
        foreach (Shape shape in shapes)
        {
            // Get the color - all shapes know their color!
            string color = shape.GetColor();
            
            // Get the area - each shape calculates it differently, but we don't have to worry about that!
            // The computer automatically uses the right GetArea method for each shape
            // This is POLYMORPHISM - same method name, different behavior!
            double area = shape.GetArea();
            
            // Show the results
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
        
        
        // WHAT IS POLYMORPHISM?
        // Polymorphism means "many forms"
        // In this program, GetArea() has many forms:
        // - For squares: side × side
        // - For rectangles: length × width  
        // - For circles: π × radius × radius
        //
        // But we can call them all the same way: shape.GetArea()
        // The computer figures out which version to use based on what type of shape it is!
        // This makes our code much easier to write and understand.
    }
}
