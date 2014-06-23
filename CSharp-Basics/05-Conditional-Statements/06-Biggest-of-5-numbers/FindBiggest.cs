//Write a program that finds the biggest of five numbers by using only five if statements. 

using System;

class GreatestNumber
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
        Console.Title = "Greatest of five numbers";
        Console.WriteLine("Input five integers.");
        Console.Write("1: ");
        int first = IntegerCheck(Console.ReadLine());
        Console.Write("2: ");
        int second = IntegerCheck(Console.ReadLine());
        Console.Write("3: ");
        int third = IntegerCheck(Console.ReadLine());
        Console.Write("4: ");
        int fourth = IntegerCheck(Console.ReadLine());
        Console.Write("5: ");
        int fifth = IntegerCheck(Console.ReadLine());
        
        double biggest = first;

        if (biggest < second)
        {
            biggest = second;
        }
        if (biggest < third)
        {
            biggest = third;
        }
        if (biggest < fourth)
        {
            biggest = fourth;
        }
        if (biggest < fifth)
        {
            biggest = fifth;
        }
        Console.WriteLine("The greatest variable is: {0}", biggest);
    }
}