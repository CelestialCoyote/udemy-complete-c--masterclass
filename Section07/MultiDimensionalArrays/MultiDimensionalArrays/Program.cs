using System;

namespace MultiDimensionalArrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 2D array.
            int[,] array2D = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine($"Central value is {array2D[1,1]}");
            Console.WriteLine($"Bottom left value is {array2D[2, 0]}");


            // 3D array.
            string[,,] threeD = new string[,,]
            {
                {
                    { "000", "001" },
                    { "010", "011" },
                    { "Hi there", "What's up" }
                },
                {
                    { "100", "101" },
                    { "110", "111" },
                    { "Another one", "Last entry" }
                }
            };

            Console.WriteLine($"The value is {threeD[1, 1, 0]}");
            Console.WriteLine($"Bottom left first group value is {threeD[0, 2, 0]}");
            Console.WriteLine($"Last entry value is {threeD[1, 2, 1]}");

            Console.ReadKey();
        }
    }
}
