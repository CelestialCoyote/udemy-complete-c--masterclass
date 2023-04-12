using System;

namespace ArraysAsParameters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] studentGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentGrades);

            foreach (int grade in studentGrades)
            {
                Console.WriteLine($"Grade {grade}");
            }

            Console.WriteLine($"The average is {averageResult}");


            int[] happiness = new int[] { 9, 13, 42, 73, 99 };
            Add2(happiness);

            foreach (int num in happiness)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;

            return average;
        }

        static int[] Add2(int[] xArray)
        {
            //int[] newArray = new int[intArray.Length];

            for (int i = 0; i < xArray.Length; i++)
            {
                xArray[i] += 2;
            }

            return xArray;
        }
    }
}
