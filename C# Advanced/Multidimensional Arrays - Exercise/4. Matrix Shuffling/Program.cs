using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimation = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = dimation[0];
            int m = dimation[1];

            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                var rowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }
                var data = command.Split();

                if (data.Length != 5 || data[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int rowOne = int.Parse(data[1]);
                int colOne = int.Parse(data[2]);
                int rowTwo = int.Parse(data[3]);
                int colTwo = int.Parse(data[4]);

                bool isValidOne = rowOne >= 0 && rowOne < n && colOne >= 0 && colOne < m;
                bool isValidTwo = rowTwo >= 0 && rowTwo < n && colTwo >= 0 && colTwo < m;
                //bool isOutOfMatrix = rowOne < 0 || rowOne >= n || colOne < 0 || colOne >= m;

                if (!isValidOne || !isValidTwo)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                var valueOne = matrix[rowOne, colOne];
                var valueTwo = matrix[rowTwo, colTwo];

                matrix[rowOne, colOne] = valueTwo;
                matrix[rowTwo, colTwo] = valueOne;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < m; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }

                    Console.WriteLine();
                }

            }
        }
    }
}
