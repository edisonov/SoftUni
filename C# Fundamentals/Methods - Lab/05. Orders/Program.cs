using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());
            SumProduct(number, product);
        }

        private static void SumProduct(double number, string product)
        {
            
            if (product == "coffee")
            {
                Console.WriteLine($"{number * 1.50:f2}");
            }
            else if (product == "water")
            {
                Console.WriteLine($"{number * 1.00:f2}");
            }
            else if (product == "coke")
            {
                Console.WriteLine($"{number * 1.40:f2}");
            }
            else if (product == "snacks")
            {
                Console.WriteLine($"{number * 2.00:f2}");
            }

        }
    }
}
