using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int loze = int.Parse(Console.ReadLine());
            double lozeMetar = double.Parse(Console.ReadLine());
            int vinoLitri = int.Parse(Console.ReadLine());
            int rabotnici = int.Parse(Console.ReadLine());

            double totalLoze = (loze * lozeMetar) * 0.40;
            double totalVino = totalLoze / 2.5;
            

            if (totalVino >= vinoLitri)
            {
                double vinoLeft = totalVino - vinoLitri;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalVino)} liters.");
                Console.WriteLine($"{Math.Ceiling(vinoLeft)} liters left -> {Math.Ceiling(vinoLeft / rabotnici)} liters per person.");

            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(vinoLitri - totalVino)} liters wine needed.");
            }
        }
    }
}
