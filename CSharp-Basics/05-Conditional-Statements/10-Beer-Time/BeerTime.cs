//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
//a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time”
//according to the definition above or “invalid time” if the time cannot be parsed. 
//Note that you may need to learn how to parse dates and times. 

using System;

class BeerTime
{
    static void Main()
    {
        Console.Title = "Beer time";
        DateTime startTime = DateTime.Parse("1:00 pm");
        DateTime endTime = DateTime.Parse("3:00 am");
        string inputTime = Console.ReadLine();
        DateTime time;

        if (DateTime.TryParse(inputTime, out time))
        {
            if (time > startTime || time < endTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
        

    }
}