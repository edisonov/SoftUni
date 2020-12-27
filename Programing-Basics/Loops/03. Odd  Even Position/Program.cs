using System;

namespace _03._Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double evenSum = 0.0;
            double oddSum = 0.0;

            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;

            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax) // beshe else if , mislq che shte stane sus else samo
                    {
                        evenMax = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax) // beshe else if , mislq che shte stane sus else samo
                    {
                        oddMax = num;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin == double.MaxValue && oddMax == double.MinValue)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else if (oddMax == double.MinValue)
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");


            if (evenMin == double.MaxValue && evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (evenMax == double.MinValue)
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}"); 
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }

        }
    }
}
