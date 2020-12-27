using System;

namespace _07._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoli = int.Parse(Console.ReadLine());
            int zombiuli = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            double podarak = double.Parse(Console.ReadLine());

            double totalFlawars = magnoli * 3.25 + zombiuli * 4 + rozi * 3.5
                + kaktusi * 8;
            totalFlawars -= totalFlawars * 0.05;
            if (totalFlawars < podarak)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(podarak - totalFlawars)} leva.");
            }
            else
            {
                Console.WriteLine($"She is left with {Math.Floor(totalFlawars - podarak)} leva.");
            }
        }
    }
}
