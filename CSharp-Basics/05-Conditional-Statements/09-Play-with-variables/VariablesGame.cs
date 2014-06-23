//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends "*" at the end. 
//Print the result at the console. Use switch statement. 

using System;

class VariablesGame
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

    static double DoubleCheck(string check)                                       //Check if the input information is integer
    {
        while (true)
        {
            double integer;
            if (double.TryParse(check, out integer))
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
        Console.Title = "Play with variables";
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.Write("Choice: ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                {
                    Console.Write("Please enter an int: ");
                    int inputInteger = IntegerCheck(Console.ReadLine());
                    Console.WriteLine(inputInteger + 1);
                    break;
                }
            case "2":
                {
                    Console.Write("Please enter a double: ");
                    double inputDouble = DoubleCheck(Console.ReadLine());
                    Console.WriteLine(inputDouble + 1);
                    break;
                }
            case "3":
                {
                    Console.Write("Please enter a string: ");
                    string inputString = Console.ReadLine();
                    Console.WriteLine(inputString + "*");
                    break;
                }
            default:
                {
                    break;
                }
        }
    }
}