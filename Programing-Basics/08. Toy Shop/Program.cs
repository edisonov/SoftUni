using System;

namespace _08._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrais = double.Parse(Console.ReadLine());
            int pazel = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int buss = int.Parse(Console.ReadLine());

            double suma = (pazel * 2.6) + (doll * 3) + (bear * 4.1) + (minion * 8.2) + (buss * 2);
            double igrachki = pazel + doll + bear + minion + buss;
            if (igrachki > 50)
            {
                double procent = suma * 0.25;
                double sum1 = suma - procent;
                double naem = sum1 * 0.1;
                suma = suma - procent - naem;
                
            }
            else
            {
                double naem = suma * 0.1;
                suma = suma - naem;
            }

            if (suma > holidayPrais)
            {
                suma = suma - holidayPrais;
                Console.WriteLine($"Yes!{suma:f2}lv left.");
            }
            else if (suma < holidayPrais)
            {
                suma -= holidayPrais;
                Console.WriteLine($"Not enough money!{Math.Abs(suma):f2}lv needed.");
            }
        }
    }
}
