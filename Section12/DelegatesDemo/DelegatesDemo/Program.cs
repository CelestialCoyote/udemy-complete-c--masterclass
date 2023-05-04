using System;
using System.Collections.Generic;


namespace DelegatesDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };

            Console.WriteLine("----- before -----");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.RemoveAll(Filter);

            Console.WriteLine("----- after -----");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            Console.ReadKey();
        }

        static bool Filter(string s)
        {
            return s.Contains("i");
        }
    }
}
