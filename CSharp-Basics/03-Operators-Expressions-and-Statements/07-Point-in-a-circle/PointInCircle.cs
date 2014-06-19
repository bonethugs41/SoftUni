//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 

using System;

class PointInCircle
{
    static bool CheckInCircle(double x, double y)
    {
        bool isInCircle = false;
        if ((x * x) + (y * y) <= 4)
        {
            isInCircle = true;
        }
        return isInCircle;
    }
    
    static void Main()
    {
        Console.WriteLine("Enter the point coordinates.");
        Console.Write("X: ");
        double xCoordinate = double.Parse(Console.ReadLine());
        Console.Write("Y: ");
        double yCoordinate = double.Parse(Console.ReadLine());

        Console.WriteLine("Inside? \n" + CheckInCircle(xCoordinate, yCoordinate));
    }
}