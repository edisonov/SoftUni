using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger value = 0;
            int snow = 0;
            int time = 0;
            int quality = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int snowDividet = snowballSnow / snowballTime;
                BigInteger snowValue = BigInteger.Pow(snowDividet, snowballQuality);

                if (snowValue > value)
                {
                    value = snowValue;
                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;
                }
            }
            Console.WriteLine($"{snow} : {time} = {value} ({quality})");
        }
    }
}
