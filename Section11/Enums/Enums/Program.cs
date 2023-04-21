using System;

namespace Enums
{
    enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
    enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };


    class MainClass
    {
        public static void Main(string[] args)
        {
            Day fri = Day.Fri;
            Day sun = Day.Sun;
            Day a = Day.Fri;


            Console.WriteLine(fri == a);
            Console.WriteLine(Day.Mon);
            Console.WriteLine((int)Day.Mon);

            Console.WriteLine("----------------");

            Console.WriteLine((int)Month.Feb);
            Console.WriteLine((int)Month.Aug);


            Console.ReadKey();
        }
    }
}
