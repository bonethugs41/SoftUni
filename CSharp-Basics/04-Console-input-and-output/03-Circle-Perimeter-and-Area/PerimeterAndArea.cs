//Write a program that reads the radius r of a circle and prints its perimeter
//and area formatted with 2 digits after the decimal point. 

using System;
using System.Globalization;

class PerimeterAndArea
{
    static double Perimeter(double radius)
    {
        double perimeter = 2 * Math.PI * radius;

        return perimeter;
    }

    static double Area(double radius)
    {
        double area = Math.PI * radius * radius;

        return area;
    }

    static void Main()
    {
        Console.Title = "Perimeter and Area";

        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter: {0:F2}", Perimeter(radius));
        Console.WriteLine("Area: " + Area(radius).ToString("F2"));
    }
}