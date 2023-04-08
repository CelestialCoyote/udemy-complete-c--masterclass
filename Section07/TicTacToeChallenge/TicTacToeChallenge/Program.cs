using System;

namespace TicTacToeChallenge
{
    class MainClass
    {
        static char[,] playField =
        {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' }
        };

        static int turns = 0;

        public static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;

            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO('O', input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO('X', input);
                }

                SetField();

                #region
                // Check for winner.
                if (Checker(playField))
                {
                    if (player == 1)
                        Console.WriteLine("O is the winner!");
                    else
                        Console.WriteLine("X is the winner!");

                    Console.WriteLine("Press any key to reset game.");
                    Console.ReadKey();
                    Console.WriteLine("");
                    ResetField();
                    //break;
                }
                else if (turns == 10)
                {
                    Console.WriteLine("It is a draw. Press any key to reset game.");
                    Console.ReadKey();
                    Console.WriteLine("");
                    ResetField();
                }
                #endregion

                #region
                // Test is space is already taken.
                do
                {
                    Console.Write($"\nPlayer {player}: Choose your field! ");

                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number between 1 and 9.");
                    }

                    if (input == 1 && playField[0, 0] == '1')
                        inputCorrect = true;
                    else if (input == 2 && playField[0, 1] == '2')
                        inputCorrect = true;
                    else if (input == 3 && playField[0, 2] == '3')
                        inputCorrect = true;
                    else if (input == 4 && playField[1, 0] == '4')
                        inputCorrect = true;
                    else if (input == 5 && playField[1, 1] == '5')
                        inputCorrect = true;
                    else if (input == 6 && playField[1, 2] == '6')
                        inputCorrect = true;
                    else if (input == 7 && playField[2, 0] == '7')
                        inputCorrect = true;
                    else if (input == 8 && playField[2, 1] == '8')
                        inputCorrect = true;
                    else if (input == 9 && playField[2, 2] == '9')
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\nIncorrect input! Please choose another space.");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
                #endregion

            } while (true);
        }


        public static void SetField()
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {playField[0, 0]} | {playField[0, 1]} | {playField[0, 2]} ");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {playField[1, 0]} | {playField[1, 1]} | {playField[1, 2]} ");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine($" {playField[2, 0]} | {playField[2, 1]} | {playField[2, 2]} ");
            Console.WriteLine("   |   |   ");

            turns++;
        }

        public static void EnterXorO(char playerSign, int input)
        {
            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
            }
        }

        public static bool Checker(char[,] board)
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

        public static void ResetField()
        {
            char[,] playFieldInitial =
            {
                {'1', '2', '3' },
                {'4', '5', '6' },
                {'7', '8', '9' }
            };

            playField = playFieldInitial;
            SetField();
            turns = 0;
        }
    }
}
