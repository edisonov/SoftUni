using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skuPraceKg = double.Parse(Console.ReadLine());
            double cacaPraceKg = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            double kgMidi = double.Parse(Console.ReadLine());

            double palamudPrace = (skuPraceKg * 0.60) + skuPraceKg;
            double palamud = palamudPrace * kgPalamud;
            double safridPrace = (cacaPraceKg * 0.80) + cacaPraceKg;
            double safrid = safridPrace * kgSafrid;
            double midi = kgMidi * 7.50;
            double total = palamud + safrid + midi;
            Console.WriteLine($"{total:F2}");

        }
    }
}
