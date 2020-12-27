using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbarStart = int.Parse(Console.ReadLine());
            int numbarEnd = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = numbarStart; i <= numbarEnd; i++)
            {
                sum += i;
                Console.Write($" {i}");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
