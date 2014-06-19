//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
// The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. 

using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Input an unsigned integer: ");
        uint number = uint.Parse(Console.ReadLine());

        uint numberRightThree = number >> 3;
        uint bit = numberRightThree & 1;

        Console.WriteLine("The binary representation of {0} is: {1}", number, Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine("The third bit is {0}", bit);
    }
}
