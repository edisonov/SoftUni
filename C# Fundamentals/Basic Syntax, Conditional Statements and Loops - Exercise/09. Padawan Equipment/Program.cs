using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double result = 0;
            int belts = students / 6;
            double studentProcent = Math.Ceiling((students * 0.1) + students);

            result = (studentProcent * priceLightsabers) + ((students - belts) * priceBelts) + (students * priceRobes);

            if (result > price)
            {
                Console.WriteLine($"Ivan Cho will need {result - price:f2}lv more.");
            }
            else if (result <= price)
            {
                Console.WriteLine($"The money is enough - it would cost {result:f2}lv.");
            }
        }
    }
}
