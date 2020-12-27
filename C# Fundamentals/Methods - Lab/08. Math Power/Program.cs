using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());
            double result = RaiseToPower(num, value);
            Console.WriteLine(result);

        }

        static double RaiseToPower(double num, int value)
        {
            double result = Math.Pow(num, value);
            return result;
        }
        
    }
}
