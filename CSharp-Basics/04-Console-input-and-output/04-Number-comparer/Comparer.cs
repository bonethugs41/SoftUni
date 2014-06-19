//Write a program that gets two numbers from the console and prints the greater of them. 
//Try to implement this without if statements.

using System;

class Comparer
{
    static void Main()
    {
        Console.Title = "Number comparer";

        Console.Write("Input a and b\na: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Greater number is " + Math.Max(firstNumber, secondNumber) + ".");
    }
}