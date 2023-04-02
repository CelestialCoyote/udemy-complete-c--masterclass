using System;

namespace Decisions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;

            if (int.TryParse(temperature, out number))
                numTemp = number;
            else
                numTemp = 0;

            if (numTemp < 20) {
                Console.WriteLine("Take the coat.");
            } else if (numTemp == 20) {
                Console.WriteLine("Casual.");
            } else {
                Console.WriteLine("Shorts and t-shirt.");
            }

            Console.Read();
        }
    }
}
