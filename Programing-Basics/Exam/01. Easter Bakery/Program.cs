using System;

namespace _01._Easter_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double praceKgBrashno = double.Parse(Console.ReadLine());
            double kgBrashno = double.Parse(Console.ReadLine());
            double kgShugar = double.Parse(Console.ReadLine());
            double qica = double.Parse(Console.ReadLine());
            double maq = double.Parse(Console.ReadLine());

            double priceShugar = praceKgBrashno * 0.75;
            double priceQica = praceKgBrashno * 1.1;
            double priceMaq = priceShugar * 0.2;

            double sumBrashno = praceKgBrashno * kgBrashno;
            double sumShugar = kgShugar * priceShugar;
            double sumQica = qica * priceQica;
            double sumMaq = maq * priceMaq;

            double total = sumBrashno + sumShugar + sumQica + sumMaq;
            Console.WriteLine($"{total:f2}");
        }
    }
}
