                                                                                                                 
┌──(ani㉿kali)-[~/Desktop/OKC/Lesson1/Homework1]
└─$ cat Program.cs 
using System;

class Homework1
{
    static void Main(string[] args)
    {
        // Name, surname, city >o<
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.Write("What is your surname? ");
        string surname = Console.ReadLine();

        Console.Write("Where do you live currently? ");
        string cityname = Console.ReadLine();

        Console.WriteLine($"Ես {name} {surname} եմ, ապրում եմ {cityname}-ում։");

        /* Number operations  :) */
        Console.Write("Input first number: ");
        double number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input second number: ");
        double number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sum: {number1 + number2}");
        Console.WriteLine($"Difference: {number1 - number2}");
        Console.WriteLine($"Product: {number1 * number2}");

        if (number2 != 0)
        {
            Console.WriteLine($"Division: {number1 / number2}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero");
        }

        //astxnerrrr
        Console.WriteLine("*****");
        Console.WriteLine("*   *");
        Console.WriteLine("*****");
    }
}
