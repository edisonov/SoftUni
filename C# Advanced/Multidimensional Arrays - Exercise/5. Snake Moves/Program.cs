using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = input[0];
            int m = input[1];

            char[,] matrix = new char[n, m];

            string snake = Console.ReadLine();

            Queue<char> myQue = new Queue<char>();
            int counter = 0;
            int capacitivi = n * m;


            for (int i = 0; i < snake.Length; i++)
            {
                myQue.Enqueue(snake[i]);
                counter++;

                if (counter == capacitivi)
                {
                    break;
                }

                if (i == snake.Length - 1)
                {
                    i = -1;
                }
            }

            for (int row = 0; row < n; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < m; col++)
                    {
                        matrix[row, col] = myQue.Dequeue();
                    }
                }
                else
                {
                    for (int col = m - 1; col > -1; col--)
                    {
                        matrix[row, col] = myQue.Dequeue();
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
