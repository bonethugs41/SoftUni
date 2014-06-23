//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements. Don’t use arrays and the built-in sorting functionality. 

using System;

class FindBiggest
{
    static double NumberCheck(string check)                                       //Check if the input information is integer
    {
        while (true)
        {
            double integer;
            if (double.TryParse(check, out integer))
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

    static void FindBiggestNumber(double a, double b, double c)
    {
        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
        else if (b > a)
        {
            if (b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
    }

    static void Main()
    {
        Console.Title = "The Biggest of 3 numbers";
        Console.Write("Input a: ");
        double a = NumberCheck(Console.ReadLine());
        Console.Write("Input b: ");
        double b = NumberCheck(Console.ReadLine());
        Console.Write("Input c: ");
        double c = NumberCheck(Console.ReadLine());
        FindBiggestNumber(a, b, c);
    }
}