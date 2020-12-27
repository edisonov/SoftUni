using System;

namespace _04._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            double numbarFlowers = double.Parse(Console.ReadLine());
            double buget = double.Parse(Console.ReadLine());

            double price = 0;
            double totalPrice = 0;


            switch (flowers)
            {
                case "Roses":
                    price = 5.0;
                    if (numbarFlowers > 80)
                    {
                        price -= price * 0.1;
                    }
                    totalPrice = price * numbarFlowers;
                    if (buget >= totalPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbarFlowers} Roses and {(buget - totalPrice):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {(totalPrice - buget):f2} leva more.");
                    }
                    break;
                case "Dahlias":
                    price = 3.80;
                    if (numbarFlowers > 90)
                    {
                        price -= price * 0.15;
                    }
                    totalPrice = price * numbarFlowers;
                    if (buget >= totalPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbarFlowers} Dahlias and {(buget - totalPrice):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {(totalPrice - buget):f2} leva more.");
                    }
                    break;
                case "Tulips":
                    price = 2.80;
                    if (numbarFlowers > 80)
                    {
                        price -= price * 0.15;
                    }
                    totalPrice = price * numbarFlowers;
                    if (buget >= totalPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbarFlowers} Tulips and {(buget - totalPrice):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {(totalPrice - buget):f2} leva more.");
                    }
                    break;
                case "Narcissus":
                    price = 3.00;
                    if (numbarFlowers < 120)
                    {
                        price += price * 0.15;
                    }
                    totalPrice = price * numbarFlowers;
                    if (buget >= totalPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbarFlowers} Narcissus and {(buget - totalPrice):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {(totalPrice - buget):f2} leva more.");
                    }
                    break;
                case "Gladiolus":
                    
                    price = 2.50;
                    if (numbarFlowers < 80)
                    {
                        price += price * 0.2;
                    }
                    totalPrice = price * numbarFlowers;
                    if (buget >= totalPrice)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {numbarFlowers} Gladiolus and {(buget - totalPrice):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {(totalPrice - buget):f2} leva more.");
                    }
                    break;
            }
           
        }
    }
}
