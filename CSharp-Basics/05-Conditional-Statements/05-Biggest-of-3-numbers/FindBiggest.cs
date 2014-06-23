//Write a program that finds the biggest of three numbers. 

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
                Console.WriteLine("a = {0} is the biggest one.", a);
            }
            else
            {
                Console.WriteLine("c = {0} is the biggest one.", c);
            }
        }
        else if (b > a)
        {
            if (b > c)
            {
                Console.WriteLine("b = {0} is the biggest one.", b);
            }
            else
            {
                Console.WriteLine("c = {0} is the biggest one.", c);
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