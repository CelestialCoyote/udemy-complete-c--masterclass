using System;
namespace InterfaceDemo
{
    public class Ticket : IEquatable<Ticket>
    {
        public int DurationInHours { get; set; }


        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours;
        }
    }
}
