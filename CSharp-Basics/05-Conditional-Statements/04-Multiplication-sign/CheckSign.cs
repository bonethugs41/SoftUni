//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. 
//Use a sequence of if operators. 

using System;

class CheckSign
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
        Console.Title = "Multiplication sign";
        Console.Write("Input first integer: ");
        int a = IntegerCheck(Console.ReadLine());
        Console.Write("Input second integer: ");
        int b = IntegerCheck(Console.ReadLine());
        Console.Write("Input third integer: ");
        int c = IntegerCheck(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("Product is 0.");
        }
        else if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("Sign is +.");
        }
        else if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine("Sign is +.");
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("Sign is +.");
        }
        else if (a < 0 && b > 0 && c < 0)
        {
            Console.WriteLine("Sign is +.");
        }
        else
        {
            Console.WriteLine("Sign is -.");
        }
    }
}