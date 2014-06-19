//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. 

using System;

class Devide
{
    static void Main()
    {
        Console.Write("Input a number: ");
        int number = int.Parse(Console.ReadLine());

        if ((number % 5 == 0) && (number % 7 == 0))
        {
            Console.WriteLine("{0} is divisibe by 7 and 5 at the same time!", number);
        }
        else
        {
            Console.WriteLine("{0} is not divisibe by 7 and 5 at the same time!", number);
        }
    }
}