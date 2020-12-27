using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string vipNormal = Console.ReadLine();
            double people = double.Parse(Console.ReadLine());

            double transport = 0;

            if(people > 0 && people <= 4)
            {
                transport = buget * 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                transport = buget * 0.60;
            }
            else if (people >= 10 && people <= 24)
            {
                transport = buget * 0.50;
            }
            else if (people >= 25 && people <= 49)
            {
                transport = buget * 0.40;
            }
            else if (people >= 50)
            {
                transport = buget * 0.25;
            }
            double totalBuget = buget - transport;
            if (vipNormal == "VIP")
            {
                double vip = 499.99 * people;
                if (vip < totalBuget)
                {
                    totalBuget = totalBuget - vip;
                    Console.WriteLine($"Yes! You have {totalBuget:f2} leva left.");
                }
                else
                {
                    totalBuget = vip - totalBuget;
                    Console.WriteLine($"Not enough money! You need {totalBuget:f2} leva.");
                }
            }
            else if (vipNormal == "Normal")
            {
                double normal = 249.99 * people;
                if (normal < totalBuget)
                {
                    totalBuget = totalBuget - normal;
                    Console.WriteLine($"Yes! You have {totalBuget:f2} leva left.");
                }
                else
                {
                    totalBuget = normal - totalBuget;
                    Console.WriteLine($"Not enough money! You need {totalBuget:f2} leva.");
                }

            }
        }
    }
}
