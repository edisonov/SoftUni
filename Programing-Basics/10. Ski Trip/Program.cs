using System;

namespace _10._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayHotel = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string ocenka = Console.ReadLine();

            double price = 0;
            int dayHotelTotal = dayHotel - 1;

            if (room == "room for one person")
            {
                price = dayHotelTotal * 18;
            }
            else if (room == "apartment")
            {
                if (dayHotelTotal <= 10)
                {
                    price = dayHotelTotal * 25;
                    price = price - price * 0.30;
                }
                else if (dayHotelTotal <= 15)
                {
                    price = dayHotelTotal * 25;
                    price = price - price * 0.35;
                }
                else if (dayHotelTotal > 15)
                {
                    price = dayHotelTotal * 25;
                    price = price - price * 0.50;
                }
            }
            else if (room == "president apartment")
            {
                if (dayHotelTotal <= 10)
                {
                    price = dayHotelTotal * 35;
                    price = price - price * 0.10;
                }
                else if (dayHotelTotal <= 15)
                {
                    price = dayHotelTotal * 35;
                    price = price - price * 0.15;
                }
                else if (dayHotelTotal > 15)
                {
                    price = dayHotelTotal * 35;
                    price = price - price * 0.20;
                }
            }
            if (ocenka == "positive")
            {
                price = price * 0.25 + price;
            }
            else if (ocenka == "negative")
            {
                price = price - price * 0.1;
            }
            Console.WriteLine("{0:f2}",price);
        }
    }
}
