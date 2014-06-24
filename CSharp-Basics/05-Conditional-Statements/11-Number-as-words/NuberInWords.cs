//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 

using System;

class NuberInWords
{
    static void Main()
    {
        Console.Title = "Numbers with words";
        int n;
        while (true)
        {
            Console.Write("Input number from 0 to 999: ");
            string value = Console.ReadLine();
            if ((int.TryParse(value, out n)) && (n >= 0) && (n <= 999))
            {
                break;
            }
        }
        int first = n / 100;
        int second = (n - (first * 100)) / 10;
        int third = n % 10;
        string firstValue = Convert.ToString(first);
        string secondValue = Convert.ToString(second);
        string thirdValue = Convert.ToString(third);
        switch (firstValue)
        {
            default:
                break;
            case "0":
                break;
            case "1":
                Console.Write("One hundred ");
                break;
            case "2":
                Console.Write("Two hundred ");
                break;
            case "3":
                Console.Write("Three hundred ");
                break;
            case "4":
                Console.Write("Four hundred ");
                break;
            case "5":
                Console.Write("Five hundred ");
                break;
            case "6":
                Console.Write("Six hundred ");
                break;
            case "7":
                Console.Write("Seven hundred ");
                break;
            case "8":
                Console.Write("Eight hundred ");
                break;
            case "9":
                Console.Write("Nine hundred ");
                break;
        }
        switch (secondValue)
        {
            default:
                break;
            case "0":
                if (first != 0)
                {
                    Console.Write("and ");
                }
                break;
            case "1":
                switch (thirdValue)
                {
                    default:
                        break;
                    case "0":
                        Console.Write("Ten");
                        break;
                    case "1":
                        Console.Write("Eleven");
                        break;
                    case "2":
                        Console.Write("Twelve");
                        break;
                    case "3":
                        Console.Write("Thirteen");
                        break;
                    case "4":
                        Console.Write("Fourteen");
                        break;
                    case "5":
                        Console.Write("Fifteen");
                        break;
                    case "6":
                        Console.Write("Sixteen");
                        break;
                    case "7":
                        Console.Write("Seventeen");
                        break;
                    case "8":
                        Console.Write("Eighteen");
                        break;
                    case "9":
                        Console.Write("Nineteen");
                        break;
                }
                break;
            case "2":
                Console.Write("Twenty ");
                break;
            case "3":
                Console.Write("Thirty ");
                break;
            case "4":
                Console.Write("Fourty ");
                break;
            case "5":
                Console.Write("Fifty ");
                break;
            case "6":
                Console.Write("Sixty ");
                break;
            case "7":
                Console.Write("Seventy ");
                break;
            case "8":
                Console.Write("Eighty ");
                break;
            case "9":
                Console.Write("Ninety ");
                break;
        }
        if (second != 1)
        {
            switch (thirdValue)
            {
                default:
                    break;
                case "0":
                    break;
                case "1":
                    Console.WriteLine("One");
                    break;
                case "2":
                    Console.WriteLine("Two");
                    break;
                case "3":
                    Console.WriteLine("Three");
                    break;
                case "4":
                    Console.WriteLine("Four");
                    break;
                case "5":
                    Console.WriteLine("Five");
                    break;
                case "6":
                    Console.WriteLine("Six");
                    break;
                case "7":
                    Console.WriteLine("Seven");
                    break;
                case "8":
                    Console.WriteLine("Eight");
                    break;
                case "9":
                    Console.WriteLine("Nine");
                    break;
            }
        }
    }
}