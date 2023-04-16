using System;


namespace VirtualOverrideDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog("Tikaa", 7);

            Console.WriteLine($"{dog.Name} is {dog.Age} years old.");
            dog.MakeSound();
            dog.Play();
            dog.Eat();


            Console.ReadKey();
        }
    }
}
