using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstSum = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                firstSum = firstSum + x;
            }

            int secondSum = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                secondSum = secondSum + x;
            }
            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes, sum = " + firstSum);
               
            }
            else
            {
                int diff = firstSum - secondSum;
                if (diff < 0)
                {
                    diff = -diff;
                }
                Console.WriteLine("No, diff = " + diff);
                
            }
        }
    }
}
