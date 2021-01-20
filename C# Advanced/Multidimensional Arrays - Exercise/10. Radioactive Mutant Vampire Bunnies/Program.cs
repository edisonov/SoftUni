using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimentios = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = dimentios[0];
            var m = dimentios[1];

            char[,] matrix = new char[n, m];
            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            char[] directions = Console.ReadLine().ToCharArray();
            bool isWon = false;
            bool isDead = false;

            foreach (var ch in directions)
            {
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;

                if (ch == 'U')
                {
                    newPlayerRow--;
                }
                else if (ch == 'D')
                {
                    newPlayerRow++;
                }
                else if (ch == 'L')
                {
                    newPlayerCol--;
                }
                else if (ch == 'R')
                {
                    newPlayerCol++;
                }

                if (!IsValidCell(newPlayerRow, newPlayerCol, n, m))
                {
                    isWon = true;
                    matrix[playerRow, playerCol] = '.';
                    List<int[]> bunnies = GetBunnies(matrix);
                    SpreadBunnies(bunnies, matrix);
                }
                else if (matrix[newPlayerRow, newPlayerCol] == '.')
                {
                    matrix[playerRow, playerCol] = '.';
                    matrix[newPlayerRow, newPlayerCol] = 'P';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;

                    List<int[]> bunnies = GetBunnies(matrix);
                    SpreadBunnies(bunnies, matrix);

                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        isDead = true;
                    }
                }
                else if (matrix[newPlayerRow, newPlayerCol] == 'B')
                {
                    isDead = true;
                    matrix[playerRow, playerCol] = '.';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;

                    List<int[]> bunnies = GetBunnies(matrix);
                SpreadBunnies(bunnies, matrix);

                }

                if (isDead || isWon)
                {
                    break;
                }
            }

            PrintMatrix(matrix);
            string result = "";

            if (isWon)
            {
                result += "won";
            }
            else
            {
                result += "dead";
            }

            result += $": {playerRow} {playerCol}";
            Console.WriteLine(result);

        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void SpreadBunnies(List<int[]> bunnies, char[,] matrix)
        {
            foreach (var bunny in bunnies)
            {
                int row = bunny[0];
                int col = bunny[1];

                SpreadBunny(row - 1, col, matrix);
                SpreadBunny(row + 1, col, matrix);
                SpreadBunny(row, col - 1, matrix);
                SpreadBunny(row, col + 1, matrix);

            }
        }

        private static void SpreadBunny(int row, int col, char[,] matrix)
        {
            int rowsLenght = matrix.GetLength(0);
            int colsLenght = matrix.GetLength(1);

            if (IsValidCell(row, col, rowsLenght, colsLenght))
            {
                matrix[row, col] = 'B';
            }
        }

        private static List<int[]> GetBunnies(char[,] matrix)
        {
            List<int[]> bunnies = new List<int[]>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                       bunnies.Add(new []{row, col});
                    }
                }
            }

            return bunnies;
        }

        private static bool IsValidCell(int row, int col, int n, int m)
        {
            return row >= 0 && row < n && col >= 0 && col < m;
        }
    }
}
