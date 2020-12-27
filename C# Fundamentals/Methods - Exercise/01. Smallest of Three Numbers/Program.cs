using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thurdNumber = int.Parse(Console.ReadLine());
            int minNum = Math.Min(firstNumber, Math.Min(secondNumber, thurdNumber));
            Console.WriteLine(PrintSmallsNumber(firstNumber, secondNumber, thurdNumber));
           
        }

        private static int PrintSmallsNumber(int firstNumber, int secondNumber, int thurdNumber)
        {
            int minNum = Math.Min(firstNumber, Math.Min(secondNumber, thurdNumber));
            return minNum;
        }
    }
}
