using System;
namespace VirtualOverrideDemo
{
    public class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Wuuuf!");
        }

        public override void Play()
        {
            if (IsHappy)
                base.Play();
        }
    }
}
