using System;

class Lab2
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();

        Console.WriteLine("How old are you: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Hi {name}! You are {age} years old <3");
    }
}
