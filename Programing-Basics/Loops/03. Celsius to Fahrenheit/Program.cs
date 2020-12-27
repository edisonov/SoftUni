using System;

namespace _03._Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = double.Parse(Console.ReadLine());

            double f = c * 1.80 + 32;
            Console.WriteLine($"{f:F2}");
        }
    }
}
