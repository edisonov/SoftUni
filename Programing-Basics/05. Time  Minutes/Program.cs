using System;

namespace _05._Time__Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            int secand = int.Parse(Console.ReadLine());


            if (time <= 23 && secand <= 59)
            {
                secand = secand + 15;
                if (secand > 59)
                {
                    time++;
                    secand = secand % 60;
                    if (time > 23)
                    {
                        time = 0;
                    }
                }
                if (secand < 10)
                {
                    Console.WriteLine($"{time}:0{secand}");
                }
                else
                {
                    Console.WriteLine($"{time}:{secand}");
                }
            }
            
        }
    }
}
