using System;

namespace _10._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holiday = double.Parse(Console.ReadLine());
            double weekend = double.Parse(Console.ReadLine());

            double igris = (48 - weekend) * 3 / 4;
            double igrin = (holiday * 2) / 3;
            double total = igris + weekend + igrin;

            if (year == "leap")
            {
                total += total * 0.15;
            }
            Console.WriteLine(Math.Floor(total));


        }
    }
}
