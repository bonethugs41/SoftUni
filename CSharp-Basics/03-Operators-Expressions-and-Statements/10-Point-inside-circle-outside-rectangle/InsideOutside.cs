//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2). 

using System;

class InsideOutside
{
    static bool CheckInCircle(double x, double y)
    {
        x -= 1;
        y -= 1;
        bool isInCircle = false;

        if ((x * x) + (y * y) <= 2.25)
        {
            isInCircle = true;
        }

        return isInCircle;
    }

    static bool CheckInRectangle(double x, double y)
    {
        bool isInRectangle = false;

        if (x <= 5 && x >= -1 && y >= -1 && y <= 1)
        {
            isInRectangle = true;
        }

        return isInRectangle;
    }

    static void Main()
    {
        Console.WriteLine("Enter the point coordinates.");
        Console.Write("X: ");
        double xCoordinate = double.Parse(Console.ReadLine());
        Console.Write("Y: ");
        double yCoordinate = double.Parse(Console.ReadLine());

        bool checkInCIrcle = CheckInCircle(xCoordinate, yCoordinate);
        bool checkInRectangle = CheckInRectangle(xCoordinate, yCoordinate);

        if (checkInCIrcle && checkInRectangle)
        {
            Console.WriteLine("Inside K & inside R");
        }
        else if (checkInCIrcle == false && checkInRectangle)
        {
            Console.WriteLine("Outside K & inside R");
        }
        else if (checkInCIrcle == false && checkInRectangle == false)
        {
            Console.WriteLine("Outside K & outside R");
        }
        else if (checkInCIrcle && checkInRectangle == false)
        {
            Console.WriteLine("Inside K & outside R");
        }
    }
}