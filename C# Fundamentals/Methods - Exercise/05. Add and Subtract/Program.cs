using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thurdNumber = int.Parse(Console.ReadLine());

            int sum = Sum(firstNumber, secondNumber, thurdNumber);
            Console.WriteLine(sum);
        }

        private static int Sum(int firstNumber, int secondNumber, int thurdNumber)
        {
            int result = firstNumber + secondNumber;
            return Subtract(result, thurdNumber);
        }

        private static int Subtract(int result, int thurdNumber)
        {
            return result - thurdNumber;
        }
    }
}
