//Write an expression that calculates trapezoid's area by given sides a and b and height h. 

using System;

class TrapezoidArea
{
    static double CalculateArea(double a, double b, double h)
    { 
        double area = ((a + b) / 2) * h;
        return area;
    }

    static void Main()
    {
        Console.Title = "Trapezoid's area";
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("h = ");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("Area = " + CalculateArea(a, b, h));
    }
}