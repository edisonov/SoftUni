using System;

namespace _13.Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double country = double.Parse(Console.ReadLine());

            double area = (lenght * 100) * (width * 100);
            double wardrobe = (country * 100) * (country * 100);
            double bench = area / 10;
            double totalArea = area - wardrobe - bench;
            double total = totalArea / (40 + 7000);
            Console.WriteLine(Math.Floor(total));
        }
    }
}
