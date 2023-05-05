using System;


namespace EventsAndMulticastDelegates
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEndgine renderingEndgine = new RenderingEndgine();

            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");
            Player player3 = new Player("DragonDog");

            GameEventManager.TriggerGameStart();


            Console.WriteLine("Game is Running . . . Press any key to end the game.");

            Console.ReadKey();

            GameEventManager.TriggerGameOver();


            Console.ReadKey();
        }
    }
}
