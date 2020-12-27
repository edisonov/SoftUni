using System;

namespace _09._Multiply_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            while (true)
            {
                num = double.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    double result = num * 2;
                    Console.WriteLine($"Result: {result:f2}");
                }
                else if (num < 0)
                {
                    Console.WriteLine("Negative number!");
                    break;
                }

            }
        }
    }
}
