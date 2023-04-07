using System;

namespace TicTacToeChallenge
{
    class MainClass
    {
        static string[,] game1 =
        {
            { "X", "X", "X" },
            { "O", "5", "6" },
            { "7", "O", "O" }
        };

        static string[,] game2 =
        {
            { "X", "O", "3" },
            { "X", "5", "O" },
            { "X", "O", "9" }
        };

        static string[,] game3 =
        {
            { "X", "O", "3" },
            { "4", "X", "O" },
            { "7", "O", "X" }
        };

        static string[,] game4 =
        {
            { "X", "O", "X" },
            { "X", "O", "O" },
            { "O", "X", "X" }
        };

        public static void Main(string[] args)
        {
            Console.WriteLine(Checker(game1));
            Console.WriteLine(Checker(game2));
            Console.WriteLine(Checker(game3));
            Console.WriteLine(Checker(game4));

            Console.ReadKey();
        }

        public static bool Checker(string[,] board)
        {
            for (int i = 0; i <= 2; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return true;
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return true;
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return true;


            return false;
        }
    }
}
