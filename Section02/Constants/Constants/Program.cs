using System;

namespace Constants
{
    class MainClass
    {
        // Constants as fields.
        const double PI = 3.14159265339;
        const int weeks = 52;
        const int months = 12;
        const string birthday = "08/07/15";


        public static void Main(string[] args)
        {
            Console.WriteLine($"Tikaa's birthday is {birthday}");

            Console.ReadKey();
        }
    }
}
