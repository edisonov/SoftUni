using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double kgVegetables = double.Parse(Console.ReadLine());
            double kgFruits = double.Parse(Console.ReadLine());
            double totalKgVeg = double.Parse(Console.ReadLine());
            double totalKgFru = double.Parse(Console.ReadLine());

            double totalVeg = kgVegetables * totalKgVeg;
            double totalFru = kgFruits * totalKgFru;
            double totalLv = totalVeg + totalFru;
            double euro = totalLv / 1.94;
            Console.WriteLine($"{euro:F2}");
        }
    }
}
