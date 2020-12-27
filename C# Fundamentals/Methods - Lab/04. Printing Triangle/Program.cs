using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrinTiangle(n);
        }

        private static void PrinTiangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrinLine(1, i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrinLine(1, i);
            }
        }

        private static void PrinLine(int start , int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
