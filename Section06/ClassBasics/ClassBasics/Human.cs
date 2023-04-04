using System;
namespace ClassBasics
{
    public class Human
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;


        public Human()
        {
            //Console.WriteLine("Constructor called");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void IntroduceHuman()
        {
            if (firstName != null && lastName != null && eyeColor != null && age != 0)
                Console.WriteLine($"Hello, my name is {firstName} {lastName} and I am {age} years old. My eyecolor is {eyeColor}.");
            else if (firstName != null && lastName != null && eyeColor != null)
                Console.WriteLine($"Hello, my name is {firstName} {lastName}. My eyecolor is {eyeColor}.");
            else if (firstName != null && lastName != null)
                Console.WriteLine($"Hello, my name is {firstName} {lastName}.");
            else if (firstName != null)
                Console.WriteLine($"Hello, my name is {firstName}."); 
            else
                Console.WriteLine($"Hello.");
        }
    }
}
