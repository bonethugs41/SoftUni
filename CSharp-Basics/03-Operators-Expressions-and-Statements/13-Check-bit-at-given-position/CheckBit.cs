//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. 

using System;

class CheckBit
{
    static bool CheckingBit(int number, int position)
    {
        int numberRightThree = number >> position;
        int bit = numberRightThree & 1;
        bool result = false;

        if (bit == 1)
        {
            result = true;
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Input an unsigned integer: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());

        Console.WriteLine("bit @ {0} == 1 ?\n" + CheckingBit(number, bitPosition), bitPosition);
    }
}
