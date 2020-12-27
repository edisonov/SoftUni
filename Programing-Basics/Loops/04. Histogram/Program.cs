using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int grup1 = 0;
            int grup2 = 0;
            int grup3 = 0;
            int grup4 = 0;
            int grup5 = 0;

            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());

                if (value < 200)
                {
                    grup1++;
                }
                else if (value >= 200 && value <= 399)
                {
                    grup2++;
                }
                else if (value >= 400 && value <= 599)
                {
                    grup3++;
                }
                else if (value >= 600 && value <= 799)
                {
                    grup4++;
                }
                else if (value >= 800)
                {
                    grup5++;
                }
            }
            double pecent1 = grup1 * 1.0 / n * 100;
            double pecent2 = grup2 * 1.0 / n * 100;
            double pecent3 = grup3 * 1.0 / n * 100;
            double pecent4 = grup4 * 1.0 / n * 100;
            double pecent5 = grup5 * 1.0 / n * 100;

            Console.WriteLine($"{pecent1:f2}%");
            Console.WriteLine($"{pecent2:f2}%");
            Console.WriteLine($"{pecent3:f2}%");
            Console.WriteLine($"{pecent4:f2}%");
            Console.WriteLine($"{pecent5:f2}%");
        }
    }
}
