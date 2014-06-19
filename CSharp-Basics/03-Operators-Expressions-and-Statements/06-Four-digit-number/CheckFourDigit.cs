//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//  • Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//  • Prints on the console the number in reversed order: dcba (in our example 1102).
//  • Puts the last digit in the first position: dabc (in our example 1201).
//  • Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.


using System;

class CheckFourDigit
{
    static int Sum(string number)
    {
        int sum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            sum += int.Parse(number[i].ToString());
        }

        return sum;
    }

    static int Reverse(string number)
    {
        char[] cArray = number.ToCharArray();
        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }

        int reversedNumber = int.Parse(reverse);
        return reversedNumber;
    }

    static string LastDigitInFront(string number)
    {
        char[] cArray = number.ToCharArray();
        string changedArray = cArray[3].ToString();

        for (int i = 0; i < cArray.Length - 1; i++)
        {
            changedArray += cArray[i];
        }
        
        return changedArray;
    }

    static string SecondAndThird(string number)
    {
        char[] cArray = number.ToCharArray();
        char temp = cArray[1];
        cArray[1] = cArray[2];
        cArray[2] = temp;
        string changedArray = String.Empty;

        for (int i = 0; i < cArray.Length; i++)
        {
            changedArray += cArray[i];
        }

        return changedArray;
    }

    static void Main()
    {
        Console.Write("Input a four digit number: ");
        string number = Console.ReadLine();

        Console.WriteLine("Sum of digits: " + Sum(number));
        Console.WriteLine("Reversed: " + Reverse(number));
        Console.WriteLine("Last digit in front: " + LastDigitInFront(number));
        Console.WriteLine("Second and third digits exchanged: " + SecondAndThird(number));
    }
}