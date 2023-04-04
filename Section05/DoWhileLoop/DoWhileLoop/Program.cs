using System;

namespace DoWhileLoop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            int lengthOfText = 0;
            string wholeText = "";

            do
            {
                Console.WriteLine("Please enter the name of a friend.");
                string nameOfFriend = Console.ReadLine();

                int currentLength = nameOfFriend.Length;

                lengthOfText += currentLength;
                wholeText += nameOfFriend;
            } while (lengthOfText < 20);

            Console.WriteLine($"Thanks, that was enough. {wholeText}");

            Console.Read();
        }
    }
}
