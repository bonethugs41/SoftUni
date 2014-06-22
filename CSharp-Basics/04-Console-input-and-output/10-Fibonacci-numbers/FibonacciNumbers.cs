//Write a program that reads a number n and prints on the console the first n members
//of the Fibonacci sequence (at a single line, separated by spaces)
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

using System;
using System.Numerics;

class FibonacciNumbers
{
    static int IntegerCheck(string check)                                       //Check if the input information is integer
    {
        while (true)
        {
            int integer;
            if (int.TryParse(check, out integer))
            {
                return integer;
            }
            else
            {
                Console.Write("Invalid integer, try again: ");
                check = Console.ReadLine();
            }
        }
    }

    static void Main()
    {
        Console.Title = "Fibonacci numbers";
        Console.Write("Input N: ");
        int n = IntegerCheck(Console.ReadLine());

        BigInteger first = 0;
        BigInteger second = 1;
        BigInteger third = 1;
        Console.Write(first);

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                Console.Write(" " + third);
            }

            third = first + second;
            first = second;
            second = third;
            Console.Write(" " + third);
        }
        Console.WriteLine();
    }
}