using System;

namespace ParsingExercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float myFloat = float.Parse(stringForFloat);
            int MyInt = Int32.Parse(stringForInt);

            Console.WriteLine($"myFloat = {myFloat}, myInt = {MyInt}");
            Console.ReadKey();
        }
    }
}
