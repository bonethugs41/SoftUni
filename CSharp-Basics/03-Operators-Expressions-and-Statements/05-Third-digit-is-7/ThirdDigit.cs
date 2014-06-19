//Write an expression that checks for given integer if its third digit from right-to-left is 7. 

using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Input an integer: ");
        int number = int.Parse(Console.ReadLine());

        number = number / 100;
        bool isSeven = false;
        if (number % 10 == 7)
        {
            isSeven = true;
        }

        Console.WriteLine("Third digit is 7? \n" + isSeven);
    }
}