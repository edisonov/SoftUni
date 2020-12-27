using System;

namespace _06._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            double dogFoodDay = double.Parse(Console.ReadLine());
            double catFoodDay = double.Parse(Console.ReadLine());
            double costenurka = double.Parse(Console.ReadLine());

            double dogFood = day * dogFoodDay;
            double catFood = day * catFoodDay;
            double costenurkaFood = day * (costenurka / 1000);
            double totalFood = dogFood + catFood + costenurkaFood;
            if (totalFood <= foodKg)
            {
                Console.WriteLine($"{Math.Floor(foodKg - totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood - foodKg)} more kilos of food are needed.");
            }
        }
    }
}
