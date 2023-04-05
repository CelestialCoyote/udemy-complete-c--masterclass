using System;

namespace Properties
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Box box = new Box(3, 4, 5);
            
            box.DisplayInfo();
            Console.WriteLine($"Front surface = {box.FrontSurface}");

            Console.Read();
        }
    }
}
