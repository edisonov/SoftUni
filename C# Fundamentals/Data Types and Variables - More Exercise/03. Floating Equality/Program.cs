using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNuber = double.Parse(Console.ReadLine());
            double current = 0.000001;

            if (firstNumber < secondNuber)
            {
                double temp = firstNumber;
                firstNumber = secondNuber;
                secondNuber = temp;
            }
            if (firstNumber - secondNuber < current)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
