using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometer = double.Parse(Console.ReadLine());

            double parce = 0;

            if (kilometer <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    parce = kilometer * 0.75;
                }
                else if (season == "Summer")
                {
                    parce = kilometer * 0.90;
                }
                else if (season == "Winter")
                {
                    parce = kilometer * 1.05;
                }
            }
            else if (kilometer > 5000 && kilometer <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    parce = kilometer * 0.95;
                }
                else if (season == "Summer")
                {
                    parce = kilometer * 1.10;
                }
                else if (season == "Winter")
                {
                    parce = kilometer * 1.25;
                }
            }
            else if (kilometer > 10000 && kilometer <= 20000)
            {
                parce = kilometer * 1.45;
            }
            parce = parce * 4;
            parce -= parce * 0.1;
            
            Console.WriteLine($"{parce:f2}");
        }
    }
}
