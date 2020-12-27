using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            double juniors = double.Parse(Console.ReadLine());
            double seniors = double.Parse(Console.ReadLine());
            string trase = Console.ReadLine();

            double prace = 0;
            double praceJunior = 0;
            double parseSenior = 0;
            double people = 0;

            switch (trase)
            {
                case "trail":
                    praceJunior = 5.50;
                    parseSenior = 7;
                    break;
                case "cross-country":
                    praceJunior = 8;
                    parseSenior = 9.5;
                    people = juniors + seniors;
                   
                    break;
                case "downhill":
                    praceJunior = 12.25;
                    parseSenior = 13.75;
                    break;
                case "road":
                    praceJunior = 20;
                    parseSenior = 21.50;
                    break;
            }
            prace = (juniors * praceJunior) + (seniors * parseSenior);
            if (people >= 50)
            {
                prace -= prace * 0.25;
            }
            prace -= prace * 0.05;
            Console.WriteLine($"{prace:f2}");


        }
    }
}
