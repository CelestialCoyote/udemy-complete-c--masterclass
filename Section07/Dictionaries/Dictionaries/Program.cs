using System;
using System.Collections.Generic;
using System.Linq;


namespace Dictionaries
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" }
            };

            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Artorias", 55, 35),
                new Employee("Intern", "Ernst", 22, 8),
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }


            string key = "CEO";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory[key];
                Console.WriteLine($"Employee Name: {empl.Name}, Role: {empl.Rate}, Salary: {empl.Salary}.");
            }
            else
            {
                Console.WriteLine($"No employee found with this key {key}.");
            }

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            Employee result = null;

            if (employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value Retrieved.");

                Console.WriteLine($"Employee Name: {result.Name}, Role: {result.Role}, Age: {result.Age}, Salary: {result.Salary}.");
            }
            else
                Console.WriteLine("The key does not exist.");


            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);

                Console.WriteLine($"Key: {keyValuePair.Key}");
                Employee employeeValue = keyValuePair.Value;

                Console.WriteLine($"Employee Name: {employeeValue.Name}, Role: {employeeValue.Role}, Age: {employeeValue.Age}, Salary: {employeeValue.Salary}.");
            }


            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            string keyToUpdate = "HR";

            if (employeesDirectory.ContainsKey(keyToUpdate))
            {
                employeesDirectory[keyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine($"Employee with Role/ Key: {keyToUpdate} was updated.");
            }
            else
                Console.WriteLine($"No employee found with key {keyToUpdate}.");


            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);

                Console.WriteLine($"Key: {keyValuePair.Key}");
                Employee employeeValue = keyValuePair.Value;

                Console.WriteLine($"Employee Name: {employeeValue.Name}, Role: {employeeValue.Role}, Age: {employeeValue.Age}, Salary: {employeeValue.Salary}.");
            }


            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            string keyToRemove = "Intern";

            if (employeesDirectory.Remove(keyToRemove))
                Console.WriteLine($"Employee with Role/ Key: {keyToRemove} was removed.");


            Console.ReadKey();
        }
    }


    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
