using System;
namespace Polymorphism
{
    public class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"The horsepower of the {brand} is {HP}, and the color is {Color}.");
        }

        public override void Repair()
        {
            Console.WriteLine($"The Audi {Model} ws repaired.");
        }
    }
}
