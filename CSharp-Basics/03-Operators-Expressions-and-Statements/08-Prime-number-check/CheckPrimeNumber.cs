//Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).


using System;

class CheckPrimeNumber
{
    static void Main()
    {
        Console.Title = "Prime or not?";
        Console.Write("Input a positive integer: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;

        for (int divisor = 2; divisor < number; divisor++)
        {
            if (number != divisor && number % divisor == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine("{0} is prime.", number);
        }
        else
        {
            Console.WriteLine("{0} is not prime.", number);
        }

    }
}