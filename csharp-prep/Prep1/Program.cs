using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string first_name = Console.ReadLine();
        Console.WriteLine($"Your name is {first_name}");

        Console.WriteLine("What is your second name?");
        string second_name = Console.ReadLine();
        Console.WriteLine($" Here your second name {second_name}?");
    }
}