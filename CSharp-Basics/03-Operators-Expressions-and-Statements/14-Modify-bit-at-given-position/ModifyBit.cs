//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold 
//the value v at the position p from the binary representation of n while preserving all other bits in n. 


using System;

class ModifyBit
{
    static int ModifingBit(int number, int position, int value)
    {
        int result = 0;

        if (value == 0)
        {
            int mask = ~(1 << position);
            result = number & mask;
        }
        else if (value == 1)
        {
            int mask = 1 << position;
            result = number | mask;
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Input an unsigned integer: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());

        Console.Write("Enter bit value: ");
        int bitValue = int.Parse(Console.ReadLine());

        int changedBitNumber = ModifingBit(number, bitPosition, bitValue);

        Console.WriteLine("The binary representation of {0} is: {1}", number, Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine("New number is: {0}", changedBitNumber);
        Console.WriteLine("The binary representation of {0} is: {1}", changedBitNumber, Convert.ToString(changedBitNumber, 2).PadLeft(16, '0'));
    }
}