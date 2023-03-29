using System;

namespace TryCatch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Format exception, try again.");
            }
            finally
            {
                Console.WriteLine("This is called always.");
            }

            

            Console.ReadKey();
        }
    }
}
