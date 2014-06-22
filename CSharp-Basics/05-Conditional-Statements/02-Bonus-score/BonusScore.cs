//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//•	If the score is between 1 and 3, the program multiplies it by 10.
//•	If the score is between 4 and 6, the program multiplies it by 100.
//•	If the score is between 7 and 9, the program multiplies it by 1000.
//•	If the score is 0 or more than 9, the program prints “invalid score”.


using System;

class BonusScore
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
        Console.Title = "Bonus score";
        Console.Write("Input score: ");
        int score = IntegerCheck(Console.ReadLine());

        if (score >= 1 && score <= 3)
        {
            score *= 10;
            Console.WriteLine("Score: " + score);
        }
        else if (score >= 4 && score <= 6)
        {
            score *= 100;
            Console.WriteLine("Score: " + score);
        }
        else if (score >= 7 && score <= 9)
        {
            score *= 1000;
            Console.WriteLine("Score: " + score);
        }
        else
        {
            Console.WriteLine("Invalid score.");
        }
    }
}