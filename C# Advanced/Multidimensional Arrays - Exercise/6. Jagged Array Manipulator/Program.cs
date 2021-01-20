using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jaggedMatrix = new double[n][];

            for (int row = 0; row < n; row++)
            {
                double[] rowData = Console.ReadLine().Split().Select(double.Parse).ToArray();
                jaggedMatrix[row] = rowData;
            }

            for (int row = 0; row < n - 1; row++)
            {
                var firstArr = jaggedMatrix[row];
                var SecondArr = jaggedMatrix[row + 1];

                if (firstArr.Length == SecondArr.Length)
                {
                    jaggedMatrix[row] = firstArr.Select(x => x * 2).ToArray();
                    jaggedMatrix[row + 1] = SecondArr.Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedMatrix[row] = firstArr.Select(x => x / 2).ToArray();
                    jaggedMatrix[row + 1] = SecondArr.Select(x => x / 2).ToArray();
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                var commandData = command.Split();
                var rowIndex = int.Parse(commandData[1]);
                var colIndex = int.Parse(commandData[2]);
                var value = int.Parse(commandData[3]);

                bool isValidCell = rowIndex >= 0 && rowIndex < n && colIndex >= 0 &&
                                   colIndex < jaggedMatrix[rowIndex].Length;

                if (!isValidCell)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (commandData[0] == "Add")
                {
                    jaggedMatrix[rowIndex][colIndex] += value;
                }
                else if (commandData[0] == "Subtract")
                {
                    jaggedMatrix[rowIndex][colIndex] -= value;
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedMatrix[row]));
            }

        }
    }
}
