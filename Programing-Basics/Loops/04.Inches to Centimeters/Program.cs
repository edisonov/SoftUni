using System;

namespace _04.Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double sum = num * 2.54;
            Console.WriteLine(sum);
        }
    }
}
