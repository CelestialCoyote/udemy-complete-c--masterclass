using System;

namespace SwitchStatement
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to enter.");
                    break;
                case 25:
                    Console.WriteLine("Good to go.");
                    break;
                default:
                    Console.WriteLine("What is your age?");
                    break;
            }

            string username = "Tikaa";

            switch (username)
            {
                case "Tikaa":
                    Console.WriteLine("Username is Tikaa.");
                    break;
                case "Groot":
                    Console.WriteLine("Username is Groot.");
                    break;
                default:
                    Console.WriteLine("Username is unknown");
                    break;
            }

            Console.Read();
        }
    }
}
