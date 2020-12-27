using System;

namespace _04._Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double eggs = double.Parse(Console.ReadLine());

            double sum = 0;

            string cauntry = Console.ReadLine();

            while ("Close" != cauntry)
            {
                if (cauntry == "Fill")
                {
                    double toFill = double.Parse(Console.ReadLine());
                    eggs += toFill;
                }
                if (cauntry == "Buy")
                {
                    double toBay = double.Parse(Console.ReadLine());
                    if (toBay <= eggs)
                    {
                        eggs -= toBay;
                        sum += toBay;
                    }
                    else
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggs}.");
                        break;
                    }
                }
                cauntry = Console.ReadLine();
            }
            if ("Close" == cauntry)
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{sum} eggs sold.");
            }
            
        }
    }
}
