using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearLili = int.Parse(Console.ReadLine());
            double pricePer = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());

            double price = 0;
            double toys = 0;
            double priceDay = 0;
            double brother = 0;

            for (int i = 1; i <= yearLili; i++)
            {
                if (i % 2 == 0)
                {
                    price += 10;
                    priceDay += price;
                    brother++;

                }
                else
                {
                    toys += 1;
                }
            }
            priceDay -= brother;
            toys *= priceToys;
            double totalPrice = priceDay + toys;

            if (totalPrice >= pricePer)
            {
                Console.WriteLine($"Yes! {totalPrice - pricePer:f2}");
            }
            else
            {
                Console.WriteLine($"No! {pricePer - totalPrice:f2}");
            }
        }
    }
}
