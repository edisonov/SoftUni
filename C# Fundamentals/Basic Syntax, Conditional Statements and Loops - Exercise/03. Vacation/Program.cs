using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string clas = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            if (clas == "Students")
            {
                if (day == "Friday")
                {
                    price = people * 8.45;
                    if (people >= 30)
                    {
                        price -= price * 0.15;
                    }
                }
                else if (day == "Saturday")
                {
                    price = people * 9.80;
                    if (people >= 30)
                    {
                        price -= price * 0.15;
                    }
                }
                else if (day == "Sunday")
                {
                    price = people * 10.46;
                    if (people >= 30)
                    {
                        price -= price * 0.15;
                    }
                }
               
            }
            else if (clas == "Business")
            {
                if (day == "Friday")
                {
                    price = people * 10.90;
                    if (people >= 100)
                    {
                        price -= 10 * 10.90;
                    }
                }
                else if (day == "Saturday")
                {
                    price = people * 15.60;
                    if (people >= 100)
                    {
                        price -= 10 * 15.60;
                    }
                }
                else if (day == "Sunday")
                {
                    price = people * 16;
                    if (people >= 100)
                    {
                        price -= 10 * 16;
                    }
                }
            }
            else if (clas == "Regular")
            {
                if (day == "Friday")
                {
                    price = people * 15;
                    if (people >= 10 && people <= 20)
                    {
                        price -= price * 0.05;
                    }
                }
                else if (day == "Saturday")
                {
                    price = people * 20;
                    if (people >= 10 && people <= 20)
                    {
                        price -= price * 0.05;
                    }
                }
                else if (day == "Sunday")
                {
                    price = people * 22.50;
                    if (people >= 10 && people <= 20)
                    {
                        price -= price * 0.05;
                    }
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
