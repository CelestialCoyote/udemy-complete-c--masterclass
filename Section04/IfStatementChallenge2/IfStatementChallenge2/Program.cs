using System;

namespace IfStatementChallenge2
{
    class MainClass
    {
        static int highScore = 300;
        static string highScorePlayer = "Tikaa";

        public static void Main(string[] args)
        {

            CheckScore(250, "Jackson");
            CheckScore(315, "Kalaini");
            CheckScore(330, "Tikaa");

            Console.Read();
        }

        public static void CheckScore(int score, string player)
        {
            if (score > highScore)
            {
                highScore = score;
                highScorePlayer = player;

                Console.WriteLine($"{player} has the new high score is {score}.");
            }
            else
            {
                Console.WriteLine($"The high score is still {score} held by {player}.");
               
            }
        }
    }
}
