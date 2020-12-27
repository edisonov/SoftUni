using System;

namespace Tiket_Futbol
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string TiketType = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            decimal transportCharges = 0.00M;
            decimal moneyForTicket = 0.00M;
            decimal moneyDifference = 0.00M;

            if (people <= 4)
            {
                transportCharges = 0.75M * budget;
            }
            else if (people <= 9)
            {
                transportCharges = 0.60M * budget;
            }
            else if (people <= 24)
            {
                transportCharges = 0.50M * budget;
            }
            else if (people <= 49)
            {
                transportCharges = 0.40M * budget;
            }
            else if (people <= 50)
            {
                transportCharges = 0.25M * budget;
            }
            switch (TiketType)
            {
                case "Normal":
                    moneyForTicket = people * 249.99M;
                    break;
                case "VIP":
                    moneyForTicket = people * 499.99M;
                    break;
                default:
                    moneyForTicket = people * 249.99M;
                    break;
            }
            moneyDifference = budget - transportCharges - moneyForTicket;

            string result = string.Format("Yes! You have {0:F2} leva left.",
                decimal.Round(moneyDifference, 2));
            if (moneyDifference < 0)
            {
                result = string.Format("Not enough money! You need {0:F2} leva.",
                    Math.Abs(decimal.Round(moneyDifference, 2)));
            }
            Console.WriteLine(result);
        }
    }
}
