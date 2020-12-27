using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double heigth = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area1 = ((heigth * width) * 2) - ((1.5 * 1.5) * 2);
            double area2 = ((heigth * heigth) * 2) - (1.2 * 2);
            double totalArea = (area1 + area2) / 3.4;

            double area3 = heigth * width * 2;
            double area4 = ((h * heigth) / 2) * 2;
            double totalArea1 = (area3 + area4) / 4.3;
            Console.WriteLine($"{totalArea:F2}");
            Console.WriteLine($"{totalArea1:F2}");


        }
    }
}
