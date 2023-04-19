using System;
using System.Collections.Generic;


namespace IEnumerator2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 8, 6, 2 };
            int[] numberArray = new int[] { 1, 7, 1, 3 };

            CollectionSum(numberList);

            Console.WriteLine("");
            Console.WriteLine("---------------");

            CollectionSum(numberArray);

            Console.ReadKey();
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach (int num in anyCollection)
            {
                sum += num;
            }

            Console.Write($"Sum is {sum}.");
        }
    }
}
