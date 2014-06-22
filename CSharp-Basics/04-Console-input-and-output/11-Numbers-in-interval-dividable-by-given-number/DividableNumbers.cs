//Write a program that reads two positive integer numbers
//and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. 

using System;

class DividableNumbers
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
                Console.Write("Invalid integer, try again: ");
                check = Console.ReadLine();
            }
        }
    }

    static void Main()
    {
        Console.Title = "Numbers in Interval Dividable by Given Number";

        Console.Write("Input start: ");
        int start = IntegerCheck(Console.ReadLine());
        Console.Write("Input end: ");
        int end = IntegerCheck(Console.ReadLine());
        int counter = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
                Console.Write(i + " ");
            }
        }

        Console.WriteLine("\np = " + counter);
    }
}