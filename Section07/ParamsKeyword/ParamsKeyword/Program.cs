using System;

namespace ParamsKeyword
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int min = MinV2(6, 4, 2, 8, 0, 1, 5);


            Console.WriteLine($"The minimum value: {min}.");
            Console.ReadKey();
        }


        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < min)
                    min = number;
            }

            return min;
        }
    }
}
