using System;

namespace DatatypesAndVariables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            byte myByte = 64;
            Console.WriteLine(myByte);

            sbyte mySbyte = -128;
            Console.WriteLine(mySbyte);

            int myInt = 73;
            Console.WriteLine(myInt);

            uint myUint = 0;
            Console.WriteLine(myUint);

            short myShort = -32768;
            Console.WriteLine(myShort);

            ushort myUshort = 65535;
            Console.WriteLine(myUshort);

            long myLong = -9223372036854775808;
            Console.WriteLine(myLong);

            ulong myUlong = 18446744073709551615;
            Console.WriteLine(myUlong);

            float myFloat = -1000000f;
            Console.WriteLine(myFloat);

            double myDouble = 111111111111;
            Console.WriteLine(myDouble);

            char myChar = 'T';
            Console.WriteLine(myChar);

            bool myBool = false;
            Console.WriteLine(myBool);

            string myString = "I control text";
            Console.WriteLine(myString);

            string numText = "73";
            Console.WriteLine(int.Parse(numText));


            Console.ReadKey();
        }
    }
}
