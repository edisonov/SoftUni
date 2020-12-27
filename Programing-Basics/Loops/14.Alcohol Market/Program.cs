using System;

namespace _14.Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskyPrace = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiaLiters = double.Parse(Console.ReadLine());
            double wiskyLiters = double.Parse(Console.ReadLine());

            double rakiaPrace = wiskyPrace / 2;
            double winePrace = rakiaPrace - (0.4 * rakiaPrace);
            double beerPrace = rakiaPrace - (0.8 * rakiaPrace);

            double rakia = rakiaLiters * rakiaPrace;
            double wine = wineLiters * winePrace;
            double beer = beerLiters * beerPrace;
            double wisky = wiskyLiters * wiskyPrace;

            double totalPrace = rakia + wine + beer + wisky;
            Console.WriteLine($"{totalPrace:F2}");

        }
    }
}
