using System;

namespace NullableExamples
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();


            Console.WriteLine($"Nullables: {num1}, {num2}, {num3}, {num4}, and {boolval}");


            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if (num6 == null)
                num8 = 0.0;
            else
                num8 = (double)num6;

            Console.WriteLine($"Value of num8 is {num8}");

            num8 = num7 ?? 8.53;
            Console.WriteLine($"Value of num8 is {num8}");


            Console.ReadKey();
        }
    }
}
