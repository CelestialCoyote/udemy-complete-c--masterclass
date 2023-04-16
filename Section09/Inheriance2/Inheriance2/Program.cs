using System;


namespace Inheriance2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the suppoer.", true, "Tikaani Aurora");

            Console.WriteLine(post1.ToString());


            ImagePost imagePost1 = new ImagePost("Check out my new bone", "Kalani Luna", "https://images.com/bone", true);

            Console.WriteLine(imagePost1.ToString());


            VideoPost videoPost1 = new VideoPost("Mush", "Kalani Luna", "https://video.com/bone", 15, true);

            Console.WriteLine(videoPost1.ToString());
            videoPost1.Play();
            Console.WriteLine("Pressa any key to stop the video.");
            Console.ReadKey();
            videoPost1.Stop();


            Console.ReadKey();
        }
    }
}
