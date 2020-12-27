using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double sum = length * width * height;
            double comission = (procent * sum) / 100;
            double procentLiters = sum - comission;
            double final = procentLiters * 0.001;
            Console.WriteLine($"{final:F3}");

        }
    }
}
