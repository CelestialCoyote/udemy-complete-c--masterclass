using System;

namespace Methods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string friend1 = "Kalani";
            string friend2 = "Tikaa";
            string friend3 = "Jackson";


            //WriteSomething();
            //WriteSomethingSpecific("specific text");
            //Console.WriteLine(Add(15, 31));
            //Console.WriteLine(Multiply(25, 25));
            //Console.WriteLine(Divide(25, 13));
            //Console.WriteLine(GreetFriend(friend1));
            //Console.WriteLine(GreetFriend(friend2));
            //Console.WriteLine(GreetFriend(friend3 ));
            Console.WriteLine(LowUpper("HeY ThErE !"));
            Count("HeY ThErE !");

            Console.Read();
        }


        public static void WriteSomething()
        {
            Console.WriteLine("Called from main method.");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static string GreetFriend(string friend)
        {
            return $"Hi {friend}, my friend!";
        }

        public static string LowUpper(string text)
        {
            string lower = text.ToLower();
            string upper = text.ToUpper();

            return $"{lower}{upper}";
        }

        public static void Count(string text)
        {
            Console.WriteLine($"The amount of characters is {text.Length}.");
        }
    }
}
