using System;

namespace _05._Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int horse = int.Parse(Console.ReadLine());
            int dayWork = int.Parse(Console.ReadLine());
            int pepole = int.Parse(Console.ReadLine());

            double horseWork = dayWork * 8;
            double procent = horseWork - horseWork * 0.1;
            double pepoleWork = pepole * dayWork * 2;
            horseWork = procent + pepoleWork;
            if (horseWork >= horse)
            {
                Console.WriteLine($"Yes!{Math.Round(horseWork - horse)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Ceiling(horse - horseWork)} hours needed.");
            }
        }
    }
}
