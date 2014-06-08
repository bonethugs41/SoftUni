//Which of the following values can be assigned to a variable of type float and which to a variable of type double:
//34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatOrDouble
{
    static void Main()
    {
        float floatNum1 = 12.345f;
        float floatNum2 = 3456.091f;

        double doubleNum1 = 34.567839023;
        double doubleNum2 = 8923.1234857;

        Console.WriteLine("Float numbers: \n{0}\n{1}\n", floatNum1, floatNum2);
        Console.WriteLine("Double numbers: \n{0}\n{1}", doubleNum1, doubleNum2);
    }
}