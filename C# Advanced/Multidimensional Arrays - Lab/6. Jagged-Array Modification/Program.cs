using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().Split(); 
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                var splited = command.Split();
                int row = int.Parse(splited[1]);
                int col = int.Parse(splited[2]);
                int value = int.Parse(splited[3]);

                if (row >= 0 && col >= 0 && row < n && col < n)
                {
                    if (splited[0] == "Add")
                    {
                        matrix[row, col] += value;
                    }
                    if (splited[0] == "Subtract")
                    {
                        matrix[row, col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
