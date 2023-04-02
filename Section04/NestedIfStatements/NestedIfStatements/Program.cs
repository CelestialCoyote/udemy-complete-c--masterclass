using System;

namespace NestedIfStatements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            
            Console.WriteLine("Please enter your username.");
            string userName = Console.ReadLine();

            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user.");
                Console.WriteLine($"Hi there, {userName}!");
                Console.WriteLine("Hi there, Admin.");
            }

            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in.");
            }

            Console.Read();
        }
    }
}
