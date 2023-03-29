using System;

namespace UserInput
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string input = Console.ReadLine();

       
            Console.WriteLine(Calculate());
            Console.Read();
        }


        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();

            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            return num1 + num2;
        }
    }
}
