using System;

namespace JaggedArrayChallenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[][] dogs = new string[][]
            {
                new string[]{"Kalni", "Tikaa"},
                new string[]{"Jackson", "Margeaux"},
                new string[]{"Bear", "Arrow"}
            };

            

            Console.WriteLine($"Hello {dogs[0][0]} from {dogs[1][1]}");
            Console.WriteLine($"Hello {dogs[0][1]} from {dogs[2][0]}");
            Console.WriteLine($"Hello {dogs[1][0]} from {dogs[2][1]}");

            Console.ReadKey();
        }
    }
}
