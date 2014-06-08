//100 / 100	
//Memory: 8.13 MB
//Time: 0.012 s

using System;

class Joro
{
    static void Main()
    {
        string year = Console.ReadLine();
        double holidays = double.Parse(Console.ReadLine());
        double hometownWeekends = double.Parse(Console.ReadLine());

        double weekends = 52;

        double playWeekends = (2 * (weekends - hometownWeekends)) / 3;
        double playHometown = hometownWeekends;
        double playHoliday = holidays / 2;

        double totalPLays = playHoliday + playHometown + playWeekends;
        if (year == "t")
        {
            totalPLays += 3;
        }

        Console.WriteLine(Math.Floor(totalPLays));
    }
}
