using System;

namespace _08._Toy_Shop1
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrace = double.Parse(Console.ReadLine());
            int puzzel = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBear = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int bus = int.Parse(Console.ReadLine());

            double totalPrace = puzzel * 2.6 + dolls * 3 + teddyBear * 4.1 +
                minions * 8.2 + bus * 2;
            double totalToy = puzzel + dolls + teddyBear + minions + bus;
            if (totalToy >= 50)
            {
                totalPrace -= totalPrace * 0.25;
            }
            totalPrace -= totalPrace * 0.1;
            if (totalPrace >= holidayPrace)
            {
                Console.WriteLine($"Yes! {(totalPrace - holidayPrace):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(holidayPrace - totalPrace):f2} lv needed.");
            }
        }
    }
}
