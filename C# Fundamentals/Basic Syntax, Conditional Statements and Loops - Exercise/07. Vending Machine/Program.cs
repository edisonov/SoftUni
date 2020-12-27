using System;
using System.IO;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();
            double sumCoins = 0;

            while (coins != "Start")
            {
                if (coins == "0.1" || coins == "0.2" || coins == "0.5" || coins == "1" || coins == "2")
                {
                    sumCoins += double.Parse(coins);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                coins = Console.ReadLine();
                
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                double price = 0;

                if (product == "Nuts")
                {
                    price = 2;
                }
                else if (product == "Water")
                {
                    price = 0.7;
                }
                else if (product == "Crisps")
                {
                    price = 1.5;
                }
                else if (product == "Soda")
                {
                    price = 0.8;
                }
                else if (product == "Coke")
                {
                    price = 1;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    product = Console.ReadLine();
                    continue;
                }

                sumCoins -= price;

                if (sumCoins < 0 && price != 0)
                {
                    sumCoins += price;
                    Console.WriteLine("Sorry, not enough money");
                }
                else if (sumCoins >= 0 && price >= 0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sumCoins:f2}");

        }

    }
}
