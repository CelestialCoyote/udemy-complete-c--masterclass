using System;
namespace InheritanceDemo2
{
    public class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }

        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;

            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair is destroyed.");
            Console.WriteLine($"Playing the {DestructionSound}.");
            Console.WriteLine("Spawning chair parts.");
        }
    }
}
