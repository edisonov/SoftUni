using System;

namespace _04._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = Console.ReadLine();
            string tawn = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());

            double price = 0;

            switch (tawn)
            {
                case "Sofia":
                    if (food == "coffee")
                    {
                        price = 0.50;
                    }
                    else if (food == "water")
                    {
                        price = 0.80;
                    }
                    else if (food == "beer")
                    {
                        price = 1.20;
                    }
                    else if (food == "sweets")
                    {
                        price = 1.45;
                    }
                    else if (food == "peanuts")
                    {
                        price = 1.60;
                    }

                    break;
                case "Plovdiv":
                    if (food == "coffee")
                    {
                        price = 0.40;
                    }
                    else if (food == "water")
                    {
                        price = 0.70;
                    }
                    else if (food == "beer")
                    {
                        price = 1.15;
                    }
                    else if (food == "sweets")
                    {
                        price = 1.30;
                    }
                    else if (food == "peanuts")
                    {
                        price = 1.50;
                    }

                    break;
                case "Varna":
                    if (food == "coffee")
                    {
                        price = 0.45;
                    }
                    else if (food == "water")
                    {
                        price = 0.70;
                    }
                    else if (food == "beer")
                    {
                        price = 1.10;
                    }
                    else if (food == "sweets")
                    {
                        price = 1.35;
                    }
                    else if (food == "peanuts")
                    {
                        price = 1.55;
                    }

                    break;
            }
            double total = price * num;
            Console.WriteLine(total);
        }
    }
}
