using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double pepole = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            double result = (int)Math.Ceiling(pepole / capacity);

            Console.WriteLine(result);
        }
    }
}
