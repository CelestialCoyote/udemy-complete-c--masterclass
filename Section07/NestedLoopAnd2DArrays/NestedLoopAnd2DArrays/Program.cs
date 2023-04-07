using System;

namespace NestedLoopAnd2DArrays
{
    class MainClass
    {
        static int[,] matrix =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        public static void Main(string[] args)
        {
            foreach (int number in matrix)
            {
                Console.WriteLine(number + " ");
            }

            Console.WriteLine("-------------------");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("-------------------");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("-------------------");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i, i]);
            }

            Console.WriteLine("");
            Console.WriteLine("-------------------");

            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix[i, j]);
            }


            Console.ReadKey();
        }
    }
}
