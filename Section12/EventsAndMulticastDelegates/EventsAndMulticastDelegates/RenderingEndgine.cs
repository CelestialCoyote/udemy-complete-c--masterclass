using System;
namespace EventsAndMulticastDelegates
{
    public class RenderingEndgine
    {
        public RenderingEndgine()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        private void StartGame()
        {
            Console.WriteLine("Rendering Engine Started");
            Console.WriteLine("Drawing Visuals . . . .");
        }

        private void GameOver()
        {
            Console.WriteLine("Rendering Engine Stopped");
        }

    }
}
