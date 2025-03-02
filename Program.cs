using System;

class Program
{
    delegate void NumberProces(int number);

    static void Main()
    {
        NumberProces proces = Positive;
        proces += Even;
        proces += Check;

        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            proces(number);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static void Positive(int number)
    {
        if (number > 0)
            Console.WriteLine("The number is positive.");
        else
            Console.WriteLine("The number is not positive.");
    }

    static void Even(int number)
    {
        if (number % 2 == 0)
            Console.WriteLine("The number is even.");
        else
            Console.WriteLine("The number is odd.");
    }

    static void Check(int number)
    {
        if (number % 7 == 0)
            Console.WriteLine("The number is a multiple of 7.");
        else
            Console.WriteLine("The number is not a multiple of f7.");
    }
}
