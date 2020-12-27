using System;

namespace _11._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x = Math.Abs(x1 - x2);
            double y = Math.Abs(y2 - y1);
            double area = x * y;
            double perimeter = 2 * (x + y);
            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }
    }
}
