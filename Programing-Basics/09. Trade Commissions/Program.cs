using System;

namespace _09._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());
            double price = -1.0;

            if (town == "Sofia")
            {
                if (num > 0 && num <= 500)
                {
                    price = num * 0.05;
                }
                else if (num > 500 && num <= 1000)
                {
                    price = num * 0.07;
                }
                else if (num > 1000 && num <= 10000)
                {
                    price = num * 0.08;
                }
                else if (num > 10000)
                {
                    price = num * 0.12;
                }
            }
            else if (town == "Varna")
            {
                if (num > 0 && num <= 500)
                {
                    price = num * 0.045;
                }
                else if (num > 500 && num <= 1000)
                {
                    price = num * 0.075;
                }
                else if (num > 1000 && num <= 10000)
                {
                    price = num * 0.1;
                }
                else if (num > 10000)
                {
                    price = num * 0.13;
                }
            }
            else if (town == "Plovdiv")
            {
                if (num > 0 && num <= 500)
                {
                    price = num * 0.055;
                }
                else if (num > 500 && num <= 1000)
                {
                    price = num * 0.08;
                }
                else if (num > 1000 && num <= 10000)
                {
                    price = num * 0.12;
                }
                else if (num > 10000)
                {
                    price = num * 0.145;
                }
            }
            if (price >= 0)
            {
                Console.WriteLine("{0:f2}",price);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
