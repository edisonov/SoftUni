using System;

namespace _08._Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double area1 = radius * radius * Math.PI;
            double area2 = 2 * Math.PI * radius;
            Console.WriteLine($"{area1:f2}");
            Console.WriteLine($"{area2:f2}");

        }
    }
}
