using System;

namespace InheritanceDemo2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Chair officeChair = new Chair("brown", "plastic");
            Chair gamingChair = new Chair("red", "wood");

            Car damagedCar = new Car(80f, "blue");

            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();


            Console.ReadKey();
        }
    }
}
