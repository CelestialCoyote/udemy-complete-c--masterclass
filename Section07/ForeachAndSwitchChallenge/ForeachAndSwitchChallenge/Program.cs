using System;

namespace ForeachAndSwitchChallenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Boolean valid = false;
            string inputDataType;

            Console.WriteLine("Enter a value.");
            string input = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input entered.");
            Console.WriteLine("Press 1 for String.");
            Console.WriteLine("Press 2 for Integer.");
            Console.WriteLine("Press 3 for Booleam.");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (IsAllAlpha(input))
                        Console.WriteLine("It is valid: String");
                    else
                        Console.WriteLine("It is invalid: String");

                    break;
                case 2:
                    int num;
                    valid = int.TryParse(input, out num);

                    if (valid)
                        Console.WriteLine("It is valid: Integer");
                    else
                        Console.WriteLine("It is invalid: Integer");

                    break;
                case 3:
                    bool flag = false;
                    valid = bool.TryParse(input, out flag);

                    if (valid)
                        Console.WriteLine("It is valid: Boolean");
                    else
                        Console.WriteLine("It is invalid: Boolean");
                    break;

                default:
                    Console.WriteLine("Cannot determine Data type.");
                    break;
            }


            Console.ReadKey();
        }

        static bool IsAllAlpha(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }

            return true;
        }
    }
}
