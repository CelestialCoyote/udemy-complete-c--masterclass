using System;

namespace InheritanceChallenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("John", "Smith", 30000);
            Boss boss = new Boss("Hard", "Ass", 50000, "BMW");
            Trainee greenie = new Trainee("Green", "Horn", 10000, 20, 20);

            employee.Work();
            employee.Pause();
            boss.Lead();
            greenie.Work();
            greenie.Learn();


            Console.ReadKey();
        }
    }
}
