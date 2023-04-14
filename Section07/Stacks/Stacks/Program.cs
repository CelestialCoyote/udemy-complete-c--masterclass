using System;
using System.Collections.Generic;


namespace Stacks
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            Console.WriteLine($"Top value in the stack is: {stack.Peek()}");
            stack.Push(2);
            Console.WriteLine($"Top value in the stack is: {stack.Peek()}");
            stack.Push(3);
            Console.WriteLine($"Top value in the stack is: {stack.Peek()}");

            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

            int? popItem = null;

            if (stack.Count > 0)
                popItem = stack.Pop();

            Console.WriteLine($"Popped item: {popItem}");
            Console.WriteLine($"Top value in the stack is: {stack.Peek()}");

            while (stack.Count > 0)
            {
                Console.WriteLine($"The top value {stack.Pop()} was removed from the stack");
                Console.WriteLine($"The current stack count is {stack.Count}");
                Console.WriteLine("--------------------");
            }


            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("");

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            Stack<int> numStack = new Stack<int>();

            Console.WriteLine("The numbers in the array are: ");

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
                numStack.Push(num);
            }

            Console.WriteLine("");

            Console.WriteLine("The numbers in reverse: ");

            while (numStack.Count > 0)
            {
                int number = numStack.Pop();
                Console.Write($"{number} ");
            }



            Console.ReadKey();
        }
    }
}
