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

        Console.Write("Enter number: ");
        string valueFromUser = Console.ReadLine();



        int x = int.Parse(valueFromUser); // this will make the variable into integer if have be run down.
        int y = 2;
        

        if(x > y)
        {
            Console.WriteLine("Greater");
        }
        else if (x < y)
        {
            Console.WriteLine("Less");
        }
        else
        {
            Console.WriteLine("Equal");
        }
        
        string response = "yes";

        while (response == "yes")
        {
            Console.WriteLine("Do you want to continue");
            response = Console.ReadLine();
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 2; i <= 20; i = i + 2)
        {
            Console.WriteLine(i);
        }

    }
}