using System;

namespace _08._Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string full = Console.ReadLine();
            double fullLiters = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double fullTotal = 0;
            double total = 0;
            double comisin = 0;


            if (full == "Gas")
            {
                if (card == "Yes")
                {
                    fullTotal = 0.93 - 0.08;

                    if (fullLiters > 20 && fullLiters <= 25)
                    {

                        total = fullLiters * fullTotal;
                        comisin = total - 0.08 * total;
                    }
                    else if (fullLiters > 25)
                    {
                        total = fullLiters * fullTotal;
                        comisin = total - 0.10 * total;
                    }
                    else
                    {
                        comisin = fullLiters * fullTotal;
                    }
                }
                else if (card == "No")
                {
                    fullTotal = 0.93;

                    if (fullLiters > 20 && fullLiters <= 25)
                    {

                        total = fullLiters * fullTotal;
                        comisin = total - 0.08 * total;
                    }
                    else if (fullLiters > 25)
                    {
                        total = fullLiters * fullTotal;
                        comisin = total - 0.10 * total;
                    }
                    else
                    {
                        comisin = fullLiters * fullTotal;
                    }
                }

            }
            else if (full == "Gasoline")
            {
                if (card == "Yes")
                {
                    fullTotal = 2.22 - 0.18;

                    if (fullLiters > 20 && fullLiters <= 25)
                    {

                        total = fullLiters * fullTotal;
                        comisin = total - 0.08 * total;
                    }
                    else if (fullLiters > 25)
                    {
                        total = fullLiters * fullTotal;
                        comisin = total - 0.10 * total;
                    }
                    else
                    {
                        comisin = fullLiters * fullTotal;
                    }
                }
                else if (card == "No")
                {
                    fullTotal = 2.22;

                    if (fullLiters > 20 && fullLiters <= 25)
                    {

                        total = fullLiters * fullTotal;
                        comisin = total - 0.08 * total;
                    }
                    else if (fullLiters > 25)
                    {
                        total = fullLiters * fullTotal;
                        comisin = total - 0.10 * total;
                    }
                    else
                    {
                        comisin = fullLiters * fullTotal;
                    }
                }
            }
            else if (full == "Diesel")
            {
                if (card == "Yes")
                {
                    fullTotal = 2.33 - 0.12;

                    if (fullLiters > 20 && fullLiters <= 25)
                    {

                        total = fullLiters * fullTotal;
                        comisin = total - 0.08 * total;
                    }
                    else if (fullLiters > 25)
                    {
                        total = fullLiters * fullTotal;
                        comisin = total - 0.10 * total;
                    }
                    else
                    {
                        comisin = fullLiters * fullTotal;
                    }
                }
                else if (card == "No")
                {
                    fullTotal = 2.33;

                    if (fullLiters > 20 && fullLiters <= 25)
                    {

                        total = fullLiters * fullTotal;
                        comisin = total - 0.08 * total;
                    }
                    else if (fullLiters > 25)
                    {
                        total = fullLiters * fullTotal;
                        comisin = total - 0.10 * total;
                    }
                    else
                    {
                        comisin = fullLiters * fullTotal;
                    }
                }
            }
            Console.WriteLine("{0:f2} lv.",Math.Abs(comisin));
        }      
    }
}
