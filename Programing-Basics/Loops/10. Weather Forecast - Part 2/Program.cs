using System;

namespace _10._Weather_Forecast___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if (num >= 26.00 && num <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (num >= 20.1 && num <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (num >= 15.00 && num <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (num >= 12.00 && num <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (num >= 5.00 && num <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
