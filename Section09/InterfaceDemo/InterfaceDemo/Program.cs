﻿using System;

namespace InterfaceDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);

            Console.WriteLine(t2.Equals(t1));

            Console.ReadKey();
        }
    }
}
