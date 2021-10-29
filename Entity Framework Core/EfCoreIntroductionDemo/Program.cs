using System;

namespace EfCoreIntroductionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCity = int.Parse(Console.ReadLine());

            var total = 0.0;

            for (int i = 1; i <=
                            countCity; i++)
            {
                var totalSum = 0.0;
                var cityName = Console.ReadLine();
                var price = double.Parse(Console.ReadLine());
                var price1 = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    price1 += price1 / 2;
                }


                totalSum += price - price1;

                if (i % 5 == 0)
                {
                    totalSum -= totalSum * 0.1;
                }

                total += totalSum;

                Console.WriteLine($"In {cityName} Burger Bus earned {totalSum:f2} leva.");
            }

            Console.WriteLine($"Burger Bus total profit: {total:f2} leva.");
        }
    }
}

