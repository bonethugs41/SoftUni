//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
//Note that you may need to use a for-loop. 

using System;

class SumNNumbers
{
    static int IntegerCheck(string check)                                       //Check if the input information is integer
    {
        while (true)
        {
            int integer;
            if (int.TryParse(check, out integer))
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

    static void Main()
    {
        Console.Title = "Sum of N numbers";
        Console.Write("Input N: ");
        int n = IntegerCheck(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Input number: ");
            numbers[i] = IntegerCheck(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("Sum: {0}", sum);
    }
}