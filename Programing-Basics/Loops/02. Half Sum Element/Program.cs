using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }
            int sumNumber = sum - max;
            if (max == sumNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                int diff = Math.Abs(max - sumNumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
