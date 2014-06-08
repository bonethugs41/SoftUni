//100 / 100	
//Memory: 8.21 MB
//Time: 0.012 s

using System;

class HalfSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[2 * n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int totalSum1 = 0;
        int totalSum2 = 0;

        for (int i = 0; i < numbers.Length / 2; i++)
        {
            totalSum1 += numbers[i];
        }

        for (int i = numbers.Length / 2; i < numbers.Length; i++)
        {
            totalSum2 += numbers[i];
        }

        if (totalSum1 == totalSum2)
        {
            Console.WriteLine("Yes, sum={0}", totalSum1);
        }
        else
        {
            int diff = totalSum1 - totalSum2;
            if (diff < 0)
            {
                diff *= -1;
            }
            Console.WriteLine("No, diff={0}", diff);
        }

    }
}