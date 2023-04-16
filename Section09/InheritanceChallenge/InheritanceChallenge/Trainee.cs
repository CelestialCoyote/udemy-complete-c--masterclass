using System;
namespace InheritanceChallenge
{
    public class Trainee : Employee
    {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }


        public Trainee(string firstName, string lastName, int salary, int workingHours, int schoolHours)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public override void Work()
        {
            Console.WriteLine($"Trainee, {FirstName}, works {WorkingHours} hours per week.");
        }

        public void Learn()
        {
            Console.WriteLine($"Trainee {FirstName}, is learning for {SchoolHours}.");
        }
    }
}
