using System;

class AfterTenYears
{
    static void Main()
    {
        Console.Write("How old are you now: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("After 10 years you will be " + (age + 10));
    }
}
