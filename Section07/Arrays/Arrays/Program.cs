using System;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int[] grades = new int[5];

            //grades[0] = 20;
            //grades[1] = 15;
            //grades[2] = 12;
            //grades[3] = 9;
            //grades[4] = 7;

            //Console.WriteLine($"Grade at index 0: {grades[0]}");


            //int[] grades2 = { 20, 13, 12, 8, 8 };
            //int[] grades3 = new int[] { 15, 20, 17, 18, 15 };

            //Console.WriteLine($"Length of array grades2 = {grades2.Length}");


            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Element[{i}] = {nums[i]}");
            }

            Console.WriteLine("---------------------------------");

            int counter = 0;
            foreach (int i in nums)
            {
                Console.WriteLine($"Element[{counter}] = {i}");
                counter++;
            }

            Console.WriteLine("---------------------------------");

            string[] dogs = { "Tikaa", "Kalani", "Loki", "Sif", "Jackson" };

            foreach (string i in dogs)
            {
                Console.WriteLine($"Hello, {i}");
            }


            Console.ReadKey();
        }
    }
}
