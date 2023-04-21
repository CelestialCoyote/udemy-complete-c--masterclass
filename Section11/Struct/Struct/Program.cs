using System;

namespace Struct
{
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;


        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }

        public void Display()
        {
            Console.WriteLine($"Game 1's name is: {name}");
            Console.WriteLine($"Game 1's was developed by: {developer}");
            Console.WriteLine($"Game 1's rating is: {rating}");
            Console.WriteLine($"Game 1's was released in: {releaseDate}");
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Game game1;

            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01.07.2016";

            game1.Display();


            Console.ReadKey();
        }
    }
}
