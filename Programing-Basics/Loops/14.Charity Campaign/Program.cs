using System;

namespace _14.Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double dayCampany = double.Parse(Console.ReadLine());
            double pepole = double.Parse(Console.ReadLine());
            double cake = double.Parse(Console.ReadLine());
            double corrugations = double.Parse(Console.ReadLine());
            double pancake = double.Parse(Console.ReadLine());

            double cakePrace = cake * 45;
            double corrugationsPrace = corrugations * 5.80;
            double pancakePrace = pancake * 3.20;

            double totalPraceDay = (cakePrace + corrugationsPrace + pancakePrace) * pepole;
            double totalCampany = totalPraceDay * dayCampany;
            double expense = totalCampany / 8;
            double total = totalCampany - expense;
            Console.WriteLine($"{total:F2}");



        }
    }
}
