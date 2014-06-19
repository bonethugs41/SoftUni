//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class WeightOnMoon
{
    static void Main()
    {
        Console.Write("Weight on the Earth: ");
        double weightOnEarth = double.Parse(Console.ReadLine());

        double weightOnMoon = weightOnEarth * 0.17;

        Console.WriteLine("Weight on the Moon will be: {0}", weightOnMoon);
    }
}