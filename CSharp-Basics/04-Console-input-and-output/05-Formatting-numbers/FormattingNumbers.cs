//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500),
//a floating-point b and a floating-point c and prints them in 4 virtual columns on the console.
//Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned;
//then the number a should be printed in binary form, padded with zeroes,
//then the number b should be printed with 2 digits after the decimal point, right aligned; 
//the number c should be printed with 3 digits after the decimal point, left aligned. 


using System;

class FormattingNumbers
{
    static int IntegerCheck(string check)                                       //Check if the input information is integer
    {
        while (true)
        {
            int integer;
            if (int.TryParse(check, out integer))
            {
                if (integer >= 0 && integer <= 500)
                {
                    return integer;
                }
                else
                {
                    Console.Write("Integer must be between 0 and 500, try again: ");
                    check = Console.ReadLine();
                }
            }
            else
            {
                Console.Write("Invalid integer, try again: ");
                check = Console.ReadLine();
            }
        }
    }

    static void Main()
    {
        Console.Title = "Formatting numbers";
        Console.Write("Input integer for a: ");
        int a = IntegerCheck(Console.ReadLine());
        Console.Write("Input float b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Input float c: ");
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine("|{0}|{1}|{2,10:F2}|{3,10:0.000}|", Convert.ToString(a, 16).PadRight(10, ' ').ToUpper(), Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}