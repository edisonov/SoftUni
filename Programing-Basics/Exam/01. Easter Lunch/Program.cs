using System;

namespace _01._Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            double kozunak = double.Parse(Console.ReadLine());
            double qica = double.Parse(Console.ReadLine());
            double cake = double.Parse(Console.ReadLine());

            double kozunakPrace = 3.20;
            double qicaPrace = 4.35;
            double cakePrace = 5.40;
            double boqQica = 0.15;

            double sumKozunak = kozunak * kozunakPrace;
            double sumQica = qica * qicaPrace;
            double sumCake = cake * cakePrace;
            double sumBoq = qica * 12 * boqQica;
            double total = sumKozunak + sumQica + sumCake + sumBoq;
            Console.WriteLine($"{total:f2}");
        }
    }
}
