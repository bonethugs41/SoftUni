//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static double NumberCheck(string check)                                       //Check if the input information is number
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
                Console.Write("Invalid number, try again: ");
                check = Console.ReadLine();
            }
        }
    }

    static void SolveEquation(double a, double b, double c)                     //Finds equation roots
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots.");
        }
        else if (discriminant == 0)
        {
            double realRoot = (-b) / (2 * a);
            Console.WriteLine("Root: {0, 0.00}", realRoot);
        }
        else
        {
            double firstRoot = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
            double secondRoot = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("First root: {0:F2}", firstRoot);
            Console.WriteLine("First root: {0:0.00}", secondRoot);
        }
    }

    static void Main()
    {
        Console.Title = "Quadratic Equation";
        Console.Write("Input a: ");
        double a = NumberCheck(Console.ReadLine());
        Console.Write("Input b: ");
        double b = NumberCheck(Console.ReadLine());
        Console.Write("Input c: ");
        double c = NumberCheck(Console.ReadLine());
        SolveEquation(a, b, c);
    }
}