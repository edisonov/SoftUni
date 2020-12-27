using System;

namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                totalSum += num;
            }
            Console.WriteLine(totalSum);
        }
    }
}
