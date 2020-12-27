using System;

namespace _01._Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakeryDay = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int factory = int.Parse(Console.ReadLine());

            int peopleDayBakery = bakeryDay * people;
            double sumBakery = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    double procent = peopleDayBakery * 0.75;
                    sumBakery += procent;
                }
                else
                {
                    sumBakery += peopleDayBakery;    
                }
                
            }

            Console.WriteLine($"You have produced {sumBakery} biscuits for the past month.");

            double procentBakery = 0;
            if (sumBakery > factory)
            {
                procentBakery = sumBakery - factory;
                procentBakery = (procentBakery / factory) * 100;
                Console.WriteLine($"You produce {procentBakery:f2} percent more biscuits.");
            }
            else
            {
                procentBakery = factory - sumBakery;
                procentBakery = (procentBakery / factory) * 100;
                Console.WriteLine($"You produce {procentBakery:f2} percent less biscuits.");
            }
        }
    }
}
