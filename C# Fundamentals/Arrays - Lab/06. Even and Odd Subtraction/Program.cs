using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int currentNuber = number[i];
                if (currentNuber % 2 == 0)
                {
                    evenSum += currentNuber;
                }
                else
                {
                    oddSum += currentNuber;
                }
            }
            int defenicia = evenSum - oddSum;
            Console.WriteLine(defenicia);
        }
    }
}
