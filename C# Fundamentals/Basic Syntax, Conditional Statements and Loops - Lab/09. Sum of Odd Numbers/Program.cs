using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int numbar = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(numbar);
                sum += numbar;
                numbar = numbar + 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
