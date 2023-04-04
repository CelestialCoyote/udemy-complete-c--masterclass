using System;

namespace BreakContinue
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //for(int counter = 0; counter < 10; counter++)
            //{
            //    Console.WriteLine(counter);

            //    if(counter == 3)
            //    {
            //        Console.WriteLine("At 3 we stop.");
            //        break;
            //    }
            //}

            Run();
            Console.Read();
        }

        public static void Run()
        {
            int i = -10;

            while (true)
            {
                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }
                   
                if (i == 10)
                    break;

                // TODO
                if (i == 11)
                {
                    Console.WriteLine(" FINAL BREAK REACHED! This should not happen!");
                    break;
                }
                Console.WriteLine(i++);
            }
        }
    }
}
