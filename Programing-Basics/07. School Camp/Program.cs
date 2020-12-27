using System;

namespace _07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string grup = Console.ReadLine();
            double student = double.Parse(Console.ReadLine());
            double night = double.Parse(Console.ReadLine());

            double prace = 0;
            double boyGarle = 0;
            string sport = "";


            if (season == "Winter")
            {
                if (grup == "girls")
                {
                    sport = "Gymnastics";
                    prace = night * 9.6 * student;
                }
                else if (grup == "boys")
                {
                    sport = "Judo";
                    prace = night * 9.6 * student;
                }
                else if (grup == "mixed")
                {
                    sport = "Ski";
                    prace = night * 10 * student;
                }
            }
            else if (season == "Spring")
            {
                if (grup == "girls")
                {
                    sport = "Athletics";
                    prace = night * 7.2 * student;
                }
                else if (grup == "boys")
                {
                    sport = "Tennis";
                    prace = night * 7.2 * student;
                }
                else if (grup == "mixed")
                {
                    sport = "Cycling";
                    prace = night * 9.5 * student;
                }
            }
            else if (season == "Summer")
            {
                if (grup == "girls")
                {
                    sport = "Volleyball";
                    prace = night * 15 * student;
                }
                else if (grup == "boys")
                {
                    sport = "Football";
                    prace = night * 15 * student;
                }
                else if (grup == "mixed")
                {
                    sport = "Swimming";
                    prace = night * 20 * student;
                }
            }
            if (student >= 50)
            {
                prace -= prace * 0.5;
            }
            else if (student >= 20 && student < 50)
            {
                prace -= prace * 0.15;
            }
            else if (student >= 10 && student < 20)
            {
                prace -= prace * 0.05;
            }
            Console.WriteLine($"{sport} {prace:f2} lv.");

        }
    }
}
