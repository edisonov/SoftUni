using System;

namespace _06.Godzila
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double praceStatist = double.Parse(Console.ReadLine());

            double dekor = budget * 0.1;
            double price = statist * praceStatist;
            if (statist > 150)
            {
                price = price - price * 0.1;
            }
            double total = price + dekor;
            double totalPrice = Math.Abs( budget - total);

            if (total > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {totalPrice:f2} leva left.");
            }
        }
    }
}
