using System;

namespace _06._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string seson = Console.ReadLine();

            double money = 0;
            string destinationResult = "";
            string holidayInformation = "";

            if (buget <= 100)
            {
                destinationResult = "Bulgaria";
                if (seson == "summer")
                {
                    money = buget * 0.3;
                    holidayInformation = string.Format("Camp - {0:f2}", money);
                }
                else
                {
                    money = buget * 0.7;
                    holidayInformation = string.Format("Hotel - {0:f2}", money);
                }
            }
            else if (buget <= 1000)
            {
                destinationResult = "Balkans";
                if (seson == "summer")
                {
                    money = buget * 0.4;
                    holidayInformation = string.Format("Camp - {0:f2}", money);
                }
                else
                {
                    money = buget * 0.8;
                    holidayInformation = string.Format("Hotel - {0:f2}", money);
                }
            }
            else
            {
                destinationResult = "Europe";
                money = buget * 0.9;
                holidayInformation = string.Format("Hotel - {0:f2}", money);

            }
            Console.WriteLine("Somewhere in {0}", destinationResult);
            Console.WriteLine(holidayInformation);



        }
    }
}
