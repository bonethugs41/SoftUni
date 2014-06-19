//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
{
    static void Main()
    {

        //Check the proper work of the following code with 255

        Console.Title = "Bit exchange";
        Console.WriteLine("Enter a number to exchange bits 3, 4 and 5 with 24, 25, 26:");
        uint number = uint.Parse(Console.ReadLine());

        //The following 6 paragraphs will give us the value of the concrete bit

        uint firstMask = 1 << 3;
        uint uintFirstMask = number & firstMask;
        uint bit3 = uintFirstMask >> 3;

        uint secondMask = 1 << 4;
        uint uintSecondMask = number & secondMask;
        uint bit4 = uintSecondMask >> 4;

        uint thirdMask = 1 << 5;
        uint uintThirdMask = number & thirdMask;
        uint bit5 = uintThirdMask >> 5;

        uint fourthMask = 1 << 24;
        uint uintFourthMask = number & fourthMask;
        uint bit24 = uintFourthMask >> 24;

        uint fifthMask = 1 << 25;
        uint uintFifthMask = number & fifthMask;
        uint bit25 = uintFifthMask >> 25;

        uint sixthMask = 1 << 26;
        uint uintSixthMask = number & sixthMask;
        uint bit26 = uintSixthMask >> 26;

        //Now we will switch the bit positions

        uint newNumber;
        uint check;

        if (bit3 == 0)
        {
            uint mask = ~((uint)(1 << 24));
            check = number & mask;
        }
        else
        {
            uint mask = 1 << 24;
            check = number | mask;
        }
        newNumber = check;

        //************************************************

        if (bit4 == 0)
        {
            uint mask = ~((uint)(1 << 25));
            check = newNumber & mask;
        }
        else
        {
            uint mask = 1 << 25;
            check = newNumber | mask;
        }
        newNumber = check;

        //************************************************

        if (bit5 == 0)
        {
            uint mask = ~((uint)(1 << 26));
            check = newNumber & mask;
        }
        else
        {
            uint mask = 1 << 26;
            check = newNumber | mask;
        }
        newNumber = check;

        //************************************************

        if (bit24 == 0)
        {
            uint mask = ~((uint)(1 << 3));
            check = newNumber & mask;
        }
        else
        {
            uint mask = 1 << 3;
            check = newNumber | mask;
        }
        newNumber = check;

        //************************************************

        if (bit25 == 0)
        {
            uint mask = ~((uint)(1 << 4));
            check = newNumber & mask;
        }
        else
        {
            uint mask = 1 << 4;
            check = newNumber | mask;
        }
        newNumber = check;

        //************************************************

        if (bit26 == 0)
        {
            uint mask = ~((uint)(1 << 5));
            check = newNumber & mask;
        }
        else
        {
            uint mask = 1 << 5;
            check = newNumber | mask;
        }
        newNumber = check;

        Console.WriteLine("The binary represantation of the input number is: \n{0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The binary represantation of the modified number is: \n{0}", Convert.ToString(newNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("The modified number is: {0}", newNumber);
    }
}