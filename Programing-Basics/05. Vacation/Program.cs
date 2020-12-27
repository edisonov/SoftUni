using System;

namespace _05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string seaseon = Console.ReadLine();

            double prace = 0;
            string location = "";
            string hotel = "";

            if (buget <= 1000)
            {
                hotel = "Camp";
                if (seaseon == "Summer")
                {
                    location = "Alaska";
                    prace = buget * 0.65;
                }
                else if (seaseon == "Winter")
                {
                    location = "Morocco";
                    prace = buget * 0.45;
                }
            }
            else if (buget > 1000 && buget <= 3000)
            {
                hotel = "Hut";
                if (seaseon == "Summer")
                {
                    location = "Alaska";
                    prace = buget * 0.8;
                }
                else if (seaseon == "Winter")
                {
                    location = "Morocco";
                    prace = buget * 0.6;
                }
            }
            else if (buget > 3000)
            {
                hotel = "Hotel";
                if (seaseon == "Summer")
                {
                    location = "Alaska";
                    prace = buget * 0.9;
                }
                else if (seaseon == "Winter")
                {
                    location = "Morocco";
                    prace = buget * 0.9;
                }
            }
            Console.WriteLine($"{location} - {hotel} - {prace:f2}");
        }
    }
}
