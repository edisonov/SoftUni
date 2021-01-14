using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalQantity = int.Parse(Console.ReadLine());
            int[] oredersArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxOrders = 0;

            Queue<int> orders = new Queue<int>(oredersArr);

            while (orders.Any())
            {
                int currentOrder = orders.Peek();

                if (currentOrder > maxOrders)
                {
                    maxOrders = currentOrder;
                }

                if (totalQantity < currentOrder)
                {
                    break;
                }

                orders.Dequeue();
                totalQantity -= currentOrder;
            }

            Console.WriteLine(maxOrders);

            if (orders.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
