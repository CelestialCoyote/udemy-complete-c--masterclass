using System;

namespace DateTimeExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2015, 8, 7);

            Console.WriteLine($"Tikaa's birthday is {dateTime}.");

            // Current date.
            Console.WriteLine($"Today's date: {DateTime.Today}");
            // Current date and time.
            Console.WriteLine($"Today' date with current time: {DateTime.Now}");
            // Tomorrow's date and time.
            Console.WriteLine($"Tomorrow's date: {GetTomorrow()}");
            // Today is.
            Console.WriteLine($"Today is: {DateTime.Today.DayOfWeek}");
            // Get a day of any year.
            Console.WriteLine($"First day of 1999: {GetFirstDayOfYear(1999)}");
            // Get days in month.
            Console.WriteLine($"Number of days in Feb 2000: {DateTime.DaysInMonth(2000, 2)}");
            // Get minute of he day.
            Console.WriteLine($"Current minute of the hour: {DateTime.Now.Minute}");
            // Display time with format.
            Console.WriteLine($"Current time: {DateTime.Now.Hour} hours, {DateTime.Now.Minute} minutes and {DateTime.Now.Second} seconds.");


            // Get time from user and display.
            Console.WriteLine("Write a date in following format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = DateTime.Now.Subtract(dateTime);
                Console.WriteLine($"Days passed since: {daysPassed.Days}");
            }
            else
                Console.WriteLine("Wrong input");


            Console.ReadKey();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
