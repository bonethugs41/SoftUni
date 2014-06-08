//Declare five variables choosing for each of them the most appropriate of the types
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it.

using System;

class Variables
{
    static void Main()
    {
        byte byteNum = 97;
        sbyte sbyteNum = -115;
        short shortNum = -10000;
        ushort ushortNum = 52130;
        uint uintNum = 4825932;

        Console.WriteLine(byteNum + " is byte.");
        Console.WriteLine(sbyteNum + " is sbyte.");
        Console.WriteLine(shortNum + " is short.");
        Console.WriteLine(ushortNum + " is ushort.");
        Console.WriteLine(uintNum + " is uint.");
    }
}
