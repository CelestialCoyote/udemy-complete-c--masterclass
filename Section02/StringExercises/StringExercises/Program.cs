using System;

namespace StringExercises
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Challenge 1.
            //string name;


            //Console.WriteLine("Please enter your name.");
            //name = Console.ReadLine();

            //Console.WriteLine($"Name to UpperCase - {name.ToUpper()}");
            //Console.WriteLine($"Name to LowerCase - {name.ToLower()}");
            //Console.WriteLine($"Remove leading and trailing white-space - {name.Trim()}");
            //Console.WriteLine($"Get 2 characters starting at index 2 - {name.Substring(2, 2)}");

            //Console.ReadKey();


            // Challenge 2.
            Console.WriteLine("Please enter a string.");
            string str = Console.ReadLine();
            Console.WriteLine("Please enter a character to be searched.");
            char character = Console.ReadLine()[0];

            Console.WriteLine($"{character} appears at index {str.IndexOf(character)}");


            Console.WriteLine("Please enter first name.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter last name.");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Full Name - {firstName} {lastName}");

            Console.ReadKey();
        }
    }
}
