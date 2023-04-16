using System;
namespace InheritanceChallenge
{
    public class Boss : Employee
    {
        protected string CompanyCar { get; set; }

        public Boss()
        {
        }

        public Boss(string firstName, string lastName, int salary, string companyCar)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"Boss, {FirstName}, is leading and drives a {CompanyCar}.");
        }
    }
}
