using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                bool isLiters = sum + liters > 255;
                if (isLiters)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                sum += liters;
            }
            Console.WriteLine(sum);
        }
    }
}
