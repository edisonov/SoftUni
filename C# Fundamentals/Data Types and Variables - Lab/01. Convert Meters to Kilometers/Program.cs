using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meter = int.Parse(Console.ReadLine());

            decimal kilomerer = meter / 1000.0m;
            Console.WriteLine($"{kilomerer:f2}");
        }
    }
}
