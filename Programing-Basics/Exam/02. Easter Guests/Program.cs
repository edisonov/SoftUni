using System;

namespace _02._Easter_Guests
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            double praceLubo = double.Parse(Console.ReadLine());

            double brKozunak = Math.Ceiling(people / 3);
            double bgQica = people * 2;
            double priceKozunak = brKozunak * 4;
            double priceQica = bgQica * 0.45;
            double totalPrace = priceKozunak + priceQica;
            if (totalPrace <= praceLubo)
            {
                Console.WriteLine($"Lyubo bought {brKozunak} Easter bread and {bgQica} eggs.");
                Console.WriteLine("He has {0:f2} lv. left.", praceLubo - totalPrace);
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine("He needs {0:f2} lv. more.", totalPrace - praceLubo);
            }
        }
    }
}
