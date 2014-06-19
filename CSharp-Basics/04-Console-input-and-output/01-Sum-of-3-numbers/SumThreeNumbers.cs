//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumThreeNumbers
{
    static double Sum(double a, double b, double c)
    {
        double sum = a + b + c;
        return sum;
    }

    static void Main()
    {
        Console.Title = "Sum of 3 numbers";

        Console.Write("First number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Sum: " + Sum(firstNumber, secondNumber, thirdNumber));
    }
}