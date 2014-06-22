//Write a program that reads an integer number n from the console 
//and prints all the numbers in the interval [1..n], each on a single line.
//Note that you may need to use a for-loop. 

using System;

class PrintingNNumbres
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
        Console.Title = "Numbers from 1 to N";
        Console.Write("Input N: ");
        int n = IntegerCheck(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
