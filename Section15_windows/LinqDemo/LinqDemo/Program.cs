using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            OddNumbers(number);


            Console.ReadKey();
        }


        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd Numbers: ");

            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

            Console.WriteLine(oddNumbers);

            foreach (int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
