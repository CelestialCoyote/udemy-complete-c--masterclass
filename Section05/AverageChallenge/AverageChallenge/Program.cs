using System;

namespace AverageChallenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int totalScore = 0;
            int currentEntry = 0;

            while (input != "-1")
            {
                Console.WriteLine($"Last number was {currentEntry}");
                Console.WriteLine("Enter next score.");
                Console.WriteLine($"Total entries {count}");
                Console.WriteLine($"Enter -1 to calculate average score.");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    double average = (double) totalScore / (double) count;
                    Console.WriteLine($"Average score is: {average}");
                }
                if (int.TryParse(input, out currentEntry) && currentEntry > 0 && currentEntry <= 20)
                {
                    totalScore += currentEntry;
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20");
                    }
                    continue;
                }

                count++;
            }

            Console.ReadLine();
        }
    }
}
