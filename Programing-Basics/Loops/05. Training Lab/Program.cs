using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double areaHeight = (height * 100) - 100;
            double areaWidth = width * 100;
            double totalHeight = Math.Floor(areaHeight / 70);
            double totalWidth = Math.Floor(areaWidth / 120);
            double total = (totalHeight * totalWidth) - 3;
            Console.WriteLine(Math.Round(total));
        }
    }
}
