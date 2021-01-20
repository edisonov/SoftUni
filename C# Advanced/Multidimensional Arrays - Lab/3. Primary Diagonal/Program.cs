using System;
using System.Data;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int sum = 0;

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().Split();
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    sum += matrix[i, j];
                }
            }

          

            Console.WriteLine(sum);

        }
    }
}
