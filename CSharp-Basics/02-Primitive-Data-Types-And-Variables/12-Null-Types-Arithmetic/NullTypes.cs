//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console. 
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullTypes
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;

        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);

        nullDouble += 1213;
        nullInt += 77;

        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);

        nullInt = 77;
        nullDouble = 1213;

        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);
    }
}