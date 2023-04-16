using System;
namespace InheritanceChallenge
{
    public class Employee
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int Salary { get; set; }


        public Employee()
        {
        }

        public Employee(string firstName, string lastName, int salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("Working.");
        }

        public virtual void Pause()
        {
            Console.WriteLine("Not working.");
        }
    }
}
