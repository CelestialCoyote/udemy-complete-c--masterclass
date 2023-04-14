using System;
using System.Collections.Generic;


namespace Queue
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            Console.WriteLine($"The value at the front of the queue is: {queue.Peek()}");
            queue.Enqueue(2);
            Console.WriteLine($"The value at the front of the queue is: {queue.Peek()}");
            queue.Enqueue(3);
            Console.WriteLine($"The value at the front of the queue is: {queue.Peek()}");

            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("");

            while (queue.Count > 0)
            {
                Console.WriteLine($"The value of: {queue.Dequeue()} was removed.");
                Console.WriteLine($"There are: {queue.Count} values remaining.");
            }


            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("");

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in ReceiveOrdersFromBranch1())
                ordersQueue.Enqueue(o);

            foreach (Order o in ReceiveOrdersFromBranch2())
                ordersQueue.Enqueue(o);

            while (ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();
                currentOrder.ProcessOrder();
            }


            Console.ReadKey();
        }


        static Order[] ReceiveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1, 5),
                new Order(2, 4),
                new Order(6, 10)
            };

            return orders;
        }

        static Order[] ReceiveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3, 5),
                new Order(4, 4),
                new Order(5, 10)
            };

            return orders;
        }
    }

    class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed.");
        }
    }
}
