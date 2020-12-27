using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string days = Console.ReadLine();
            double reserved = double.Parse(Console.ReadLine());

            double price = 0;

            for (int i = 1; i < reserved; i++)
            {
                if (country == "France")
                {
                    if (days == "21-23")
                    {
                        price = 30;
                    }
                    else if (days == "24-27")
                    {
                        price = 35;
                    }
                    else if (days == "28-31")
                    {
                        price = 40;
                    }
                }
                else if (country == "Italy")
                {
                    if (days == "21-23")
                    {
                        price = 28;
                    }
                    else if (days == "24-27")
                    {
                        price = 32;
                    }
                    else if (days == "28-31")
                    {
                        price = 39;
                    }
                }
                else if (country == "Germany")
                {
                    if (days == "21-23")
                    {
                        price = 32;
                    }
                    else if (days == "24-27")
                    {
                        price = 37;
                    }
                    else if (days == "28-31")
                    {
                        price = 43;
                    }
                }

            }

            double total = reserved * price;
            Console.WriteLine($"Easter trip to {country} : {total:f2} leva.");
        }
    }
}
