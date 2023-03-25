using System;

namespace StringExercises
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name;


            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();

            Console.WriteLine($"Name to UpperCase - {name.ToUpper()}");
            Console.WriteLine($"Name to LowerCase - {name.ToLower()}");
            Console.WriteLine($"Remove leading and trailing white-space - {name.Trim()}");
            Console.WriteLine($"Get 2 characters starting at index 2 - {name.Substring(2, 2)}");

            Console.ReadKey();
        }
    }
}
