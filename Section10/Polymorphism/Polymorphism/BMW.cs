using System;
namespace Polymorphism
{
    public class BMW : Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"The horsepower of the {brand} is {HP}, and the color is {Color}.");
        }

        public override void Repair()
        {
            Console.WriteLine($"The BMW {Model} ws repaired.");
        }
    }
}
