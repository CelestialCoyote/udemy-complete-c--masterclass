using System;

namespace EnhancedIfStatement
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Temperature in Celcius.
            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";


            Console.WriteLine($"State of matter is {stateOfMatter}.");


            // Use ternary instead of if statement.
            temperature += 30;

            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            Console.WriteLine($"State of matter is {stateOfMatter}.");

            // Compound ternary.
            temperature += 100;

            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine($"State of matter is {stateOfMatter}.");



            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            string inputValue = string.Empty;

            Console.WriteLine("Enter current temperature: ");
            inputValue = Console.ReadLine();

            bool validateInput = int.TryParse(inputValue, out inputTemperature);

            if (validateInput)
            {
                temperatureMessage = inputTemperature <= 15 ? "too cold" :
                    (inputTemperature >= 16 && inputTemperature <= 28) ? "it is cold" :
                    inputTemperature > 28 ? "it is hot" : "";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                Console.WriteLine("Not a valid temperature.");
            }


            Console.ReadKey();
        }
    }
}
