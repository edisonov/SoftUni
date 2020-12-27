using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string price = Console.ReadLine();

            if (price == "regular" || price == "special")
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            decimal sum = 0;

            while (price != "special" && price != "regular")
            {
                decimal sumNumber = decimal.Parse(price);

                if (sumNumber < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else if (sumNumber > 0)
                {
                    sum += sumNumber;
                }
                else if (sumNumber == 0)
                {
                    Console.WriteLine("Invalid order!");
                }

                price = Console.ReadLine();
            }

            decimal taxe = sum * 0.2m;
            decimal totalSum = sum + taxe;

            if (price == "special")
            {
                totalSum -= totalSum * 0.1m;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {taxe:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalSum:f2}$");
            }
            else if (price == "regular")
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {taxe:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalSum:f2}$");
            }
        }
    }
}
