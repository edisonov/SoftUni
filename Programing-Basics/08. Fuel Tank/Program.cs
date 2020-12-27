using System;

namespace _08._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string full = Console.ReadLine().ToLower();
            double rezervoar = double.Parse(Console.ReadLine());

            if (full == "diesel" || full == "gasoline" || full == "gas")
            {
                if (rezervoar >= 25)
                {
                    Console.WriteLine($"You have enough {full}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {full}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
