using System;
namespace EventsAndMulticastDelegates
{
    public class Player
    {
        public string PlayerName { get; set; }

        public Player(string Name)
        {
            this.PlayerName = Name;

            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        private void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID: {PlayerName}");
        }

        private void GameOver()
        {
            Console.WriteLine($"Removing Player with ID: {PlayerName}");
        }
    }
}
