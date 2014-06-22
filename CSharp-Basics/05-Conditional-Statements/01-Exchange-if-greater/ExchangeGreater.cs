//Write an if-statement that takes two integer variables a and b 
//and exchanges their values if the first one is greater than the second one.
//As a result print the values a and b, separated by a space. 

using System;

class ExchangeGreater
{
    static int IntegerCheck(string check)                                       //Check if the input information is integer
    {
        while (true)
        {
            int integer;
            if (int.TryParse(check, out integer))
            {
                return integer;
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
        Console.Title = "Exchange if greater";
        Console.Write("Input a: ");
        int a = IntegerCheck(Console.ReadLine());
        Console.Write("Input b: ");
        int b = IntegerCheck(Console.ReadLine());

        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a + " " + b);
        }
        else
        {
            Console.WriteLine("Nothing happened");
        }
    }
}