using System;

class Program
{
    static void Main()
    {
        // Test all three constructors
        Fraction f1 = new Fraction();        // 1/1
        Fraction f2 = new Fraction(5);       // 5/1
        Fraction f3 = new Fraction(3, 4);    // 3/4
        Fraction f4 = new Fraction(1, 3);    // 1/3

        // Display results
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Console.WriteLine();

        // Practice using the Fraction class
        Fraction randomFraction = new Fraction();
        Random rand = new Random();

        // Loop 20 times
        for (int i = 1; i <= 20; i++)
        {
            int top = rand.Next(1, 10);
            int bottom = rand.Next(1, 10);

            randomFraction.SetTop(top);
            randomFraction.SetBottom(bottom);

            Console.WriteLine(
                $"Fraction {i}: string: {randomFraction.GetFractionString()} " +
                $"Number: {randomFraction.GetDecimalValue()}"
            );
        }
    }
}
