using System;
using System.Globalization;

namespace _10.BeerTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //beer time is after 1:00 PM and before 3:00 AM.
            //Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and
            //AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if 
            //the time cannot be parsed. Note: You may need to learn how to parse dates and times.

            Console.WriteLine("Enter a time (hh:mm tt) :");
            string timeString = Console.ReadLine();
            string format = "hh:mm tt";
            DateTime inputTime = DateTime.ParseExact(timeString,format, CultureInfo.InvariantCulture);
            DateTime startTime = DateTime.Parse("01:00 PM");
            DateTime endTime = DateTime.Parse("03:00 AM");

            if (inputTime >= startTime || inputTime <= endTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
    }
}
