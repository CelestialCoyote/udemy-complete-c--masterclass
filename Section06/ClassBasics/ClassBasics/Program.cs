using System;

namespace ClassBasics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Human tikaa = new Human("Tikaani", "Aurora", "blue", 7);
            tikaa.IntroduceHuman();

            Human kalani = new Human("Kalani", "Luna", "brown");
            kalani.IntroduceHuman();

            Human margot = new Human("Margot", "Robbie");
            margot.IntroduceHuman();

            Human jackson = new Human("Jackson");
            jackson.IntroduceHuman();

            Human dog = new Human();
            dog.IntroduceHuman();


            Console.ReadKey();
        }
    }
}
