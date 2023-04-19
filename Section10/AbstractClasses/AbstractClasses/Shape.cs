using System;


namespace AbstractClasses
{
    abstract public class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a {Name}");
        }

        public abstract double Volume();

        public Shape()
        {
        }
    }
}
