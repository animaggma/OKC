using System;

class Lab3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"First number is {number1}");
        Console.WriteLine($"Second number is {number2}");
        Console.WriteLine($"Addition: {number1 + number2}");
    }
}
