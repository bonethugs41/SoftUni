//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 

using System;

class SumNumbers
{
    static void Main()
    {
        Console.Title = "Sum of 5 numbers";
        Console.Write("Input numbers separated by space: ");
        string inputNumbers = Console.ReadLine();
        string[] splitNumbers = inputNumbers.Split(' ');
        int sum = 0;

        foreach (string number in splitNumbers)
        {
            sum += int.Parse(number);
        }

        Console.WriteLine("Sum: {0}", sum);

    }
}