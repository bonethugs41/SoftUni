//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic.
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Input the first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Input the second number: ");
        double secondNum = double.Parse(Console.ReadLine());

        firstNum = Math.Round(firstNum, 6);
        secondNum = Math.Round(secondNum, 6);

        bool isEqual = false;

        if (firstNum == secondNum)
        {
            isEqual = true;
            Console.WriteLine(isEqual);
        }
        else
        {
            Console.WriteLine(isEqual); 
        }
    }
}