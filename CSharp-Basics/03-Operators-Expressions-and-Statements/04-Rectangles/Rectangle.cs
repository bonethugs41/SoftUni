//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangle
{
    static double Perimeter(double height, double width)
    {
        double perimeter = (2 * height) + (2 * width);
        return perimeter;
    }

    static double Area(double height, double width)
    {
        double area = height * width;
        return area;
    }

    static void Main()
    {
        //input
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());
        
        //output
        Console.WriteLine("Perimeter: " + Perimeter(height, width));
        Console.WriteLine("Area: " + Area(height, width));
    }
}