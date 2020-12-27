using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            double volume = length * width;
            volume = 1 / 3.0 * volume * heigth;
            Console.Write("Length: Width: Height: ");
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
