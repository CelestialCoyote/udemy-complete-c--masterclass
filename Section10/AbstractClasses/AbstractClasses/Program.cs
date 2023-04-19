using System;

namespace AbstractClasses
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Shape[] shapes = { new Sphere(4), new Cube(3) };

            foreach(Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"{shape.Name} has a volume of {shape.Volume()}.");
            }


            Console.ReadKey();
        }
    }
}
