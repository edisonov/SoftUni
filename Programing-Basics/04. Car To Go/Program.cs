using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double parce = 0;
            string clas = "";
            string car = "";

            if (buget <= 100)
            {
                clas = "Economy class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    parce = buget * 0.35;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    parce = buget * 0.65;
                }
            }
            else if (buget > 100 && buget <= 500)
            {
                clas = "Compact class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    parce = buget * 0.45;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    parce = buget * 0.80;
                }
            }
            else if (buget > 500)
            {
                clas = "Luxury class";
                car = "Jeep";
                parce = buget * 0.90;
            }
            Console.WriteLine(clas);
            Console.WriteLine($"{car} - {parce:f2}");
        }
    }
}
