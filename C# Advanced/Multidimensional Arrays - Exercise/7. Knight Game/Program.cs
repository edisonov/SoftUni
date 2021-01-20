using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    board[row, col] = rowData[col];
                }
            }

            int removeKnightCount = 0;

            while (true)
            {
                int maxAttackedKnightCount = 0;
                int knigthRow = -1;
                int knigthCol = -1;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char symbol = board[row, col];

                        if (symbol != 'K')
                        {
                            continue;
                        }

                        int count = GetCountOfAttackedKnights(board, row, col);

                        if (count > maxAttackedKnightCount)
                        {
                            maxAttackedKnightCount = count;
                            knigthRow = row;
                            knigthCol = col;
                        }
                    }
                }

                if (maxAttackedKnightCount == 0)
                {
                    break;
                }

                board[knigthRow, knigthCol] = '0';
                removeKnightCount++;
            }

            Console.WriteLine(removeKnightCount);
        }

        private static int GetCountOfAttackedKnights(char[,] board, int row, int col)
        {
            int count = 0;

            if (ContainsKnigth(board, row - 2, col -1))
            {
                count++;
            }

            if (ContainsKnigth(board, row - 2, col + 1))
            {
                count++;
            }

            if (ContainsKnigth(board, row - 1, col - 2))
            {
                count++;
            }

            if (ContainsKnigth(board, row - 1, col + 2))
            {
                count++;
            }

            if (ContainsKnigth(board, row + 1, col - 2))
            {
                count++;
            }

            if (ContainsKnigth(board, row + 1, col + 2))
            {
                count++;
            }

            if (ContainsKnigth(board, row + 2, col - 1))
            {
                count++;
            }

            if (ContainsKnigth(board, row + 2, col + 1))
            {
                count++;
            }

            return count;
        }

        private static bool ContainsKnigth(char[,] board, int row, int col)
        {
            if (!IsValidedCell(row, col, board.GetLength(0)))
            {
                return false;
            }

            return board[row, col] == 'K';
        }

        private static bool IsValidedCell(int row, int col, int Length)
        {
            return row >= 0 && row < Length && col >= 0 && col < Length;
        }
    }
}
