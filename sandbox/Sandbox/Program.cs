 using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!!!");

        Console.Write("What is your favorite color ? ");
        string color = Console.ReadLine(); // Console.ReadLine it store the variable or anything you give to.
        Console.WriteLine($"Your Color is {color}");// This symbol $ is litellaly means this a varialble an better coming

        string school = "BYU-Idaho";
        Console.WriteLine($" I am studying at {school}."); 

        int number = 5;
        number = number +5;
        
        //string colors = "blue";


        int x = 7;
        int y = 5;
        if(x > y)
        {
            Console.WriteLine("Greater");
        }

    }
} 