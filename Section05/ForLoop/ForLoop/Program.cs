using System;

namespace ForLoop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //for (int counter = 0; counter < 10; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            for (int counter = 0; counter < 20; counter++)
            {
                if (counter % 2 != 0)
                    Console.WriteLine(counter);
            }

            Console.Read();
        }
    }
}
