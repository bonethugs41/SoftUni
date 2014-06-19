//Write an expression that extracts from given integer n the value of given bit at index p. 

using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Input an unsigned integer: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());

        int numberRightThree = number >> bitPosition;
        int bit = numberRightThree & 1;

        Console.WriteLine("The binary representation of {0} is: {1}", number, Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine("The third bit is {0}", bit);
    }
}
