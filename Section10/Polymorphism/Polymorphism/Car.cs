using System;
namespace Polymorphism
{
    public class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        protected CarIDInfo carIDInfo = new CarIDInfo();


        public Car()
        {

        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"The horsepower of the car is {HP}, and the color is {Color}.");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car is repaired.");
        }

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine($"The car has the ID of {carIDInfo.IDNum} and is owned by {carIDInfo.Owner}.");
        }
    }
}
