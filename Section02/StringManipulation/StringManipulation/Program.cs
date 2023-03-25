using System;

namespace StringManipulation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Define variables.
            int age = 11;
            string name = "Kalani";
            string job = "Siberian Husky";

            // 1. String concatenation.
            Console.WriteLine("String Concatenaton");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old.");

            // 2. String formatting.
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0} , I am {1} years old.  I am a {2}", name, age, job);

            // 3. String interpolation.
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name} , I am {age} years old.  I am a {job}");

            // 4. Verbatim strings.
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(
                @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
            );

            Console.ReadKey();
        }
    }
}
