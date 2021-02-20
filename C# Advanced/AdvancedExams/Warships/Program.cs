using System;
using System.Linq;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split(",");

            char[,] matrix = new char[n, n];

            int firstCount = 0;
            int secondCount = 0;

            int firstPlayer = 0;
            int secondPlayer = 0;

            for (int row = 0; row < n; row++)
            {
                string[] curentRow = Console.ReadLine().Split();
                
                for (int col = 0; col < curentRow.Length; col++)
                {
                    char ch = char.Parse(curentRow[col]);
                    
                        matrix[row, col] = ch;

                    if (matrix[row, col] == '>')
                    {
                        firstCount++;
                    }

                    if (matrix[row, col] == '<')
                    {
                        secondCount++;
                    }

                }
            }

           



            for (int i = 0; i < command.Length; i++)
            {
                string[] argArr = command[i].Split();
                int row = int.Parse(argArr[0]);
                int col = int.Parse(argArr[1]);

                if (i % 2 == 0)
                {
                    if (firstCount <= 0)
                    {
                        break;
                    }
                    else if (secondCount <= 0)
                    {
                        break;
                    }

                    if (IsPositionValid(row, col, n, n))
                    {
                        if (matrix[row, col] == '#')
                        {
                            matrix[row, col] = 'X';
                            if (IsPositionValid(row, col + 1, n, n))
                            {
                                if (matrix[row, col + 1] == '>')
                                {
                                    
                                    firstPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row, col + 1] == '<')
                                {
                                    firstCount--;
                                    firstPlayer++;
                                }
                                matrix[row, col + 1] = 'X';
                            }
                            if (IsPositionValid(row + 1, col, n, n))
                            {
                                if (matrix[row + 1, col] == '>')
                                { 
                                    firstPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row + 1, col] == '<')
                                {
                                    firstCount--;
                                    
                                    firstPlayer++;
                                }
                                matrix[row + 1, col] = 'X';
                            }
                            if (IsPositionValid(row + 1, col + 1, n, n))
                            {
                                if (matrix[row + 1, col + 1] == '>')
                                {
                                    
                                    firstPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row + 1, col + 1] == '<')
                                {
                                    firstCount--;
                                   
                                    firstPlayer++;
                                }
                                matrix[row + 1, col + 1] = 'X';
                            }
                            if (IsPositionValid(row, col - 1, n, n))
                            {
                                if (matrix[row, col - 1] == '>')
                                {
                                    
                                    firstPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row, col - 1] == '<')
                                {
                                    firstCount--;
                                    
                                    firstPlayer++;
                                }
                                matrix[row, col - 1] = 'X';
                            }
                            if (IsPositionValid(row - 1, col + 1, n, n))
                            {
                                if (matrix[row - 1, col + 1] == '>')
                                {
                                    
                                    firstPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row - 1, col + 1] == '<')
                                {
                                    firstCount--;
                                    
                                    firstPlayer++;
                                }
                                matrix[row - 1, col + 1] = 'X';
                            }
                            if (IsPositionValid(row - 1, col - 1, n, n))
                            {
                                if (matrix[row - 1, col - 1] == '>')
                                {
                                    
                                    firstPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row - 1, col - 1] == '<')
                                {
                                    firstCount--;
                                    
                                    firstPlayer++;
                                }
                                matrix[row - 1, col - 1] = 'X';
                            }
                            if (IsPositionValid(row + 1, col - 1, n, n))
                            {
                                if (matrix[row + 1, col - 1] == '>')
                                {
                                    
                                    firstPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row + 1, col - 1] == '<')
                                {
                                    firstCount--;
                                    
                                    firstPlayer++;
                                }
                                matrix[row + 1, col - 1] = 'X';
                            }
                            if (IsPositionValid(row - 1, col, n, n))
                            {
                                if (matrix[row  - 1, col] == '>')
                                {
                                    firstPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row - 1, col] == '<')
                                {
                                    firstCount--;
                                    firstPlayer++;
                                }
                                matrix[row - 1, col] = 'X';
                            }
                        }
                        else if (matrix[row, col] == '<')
                        {
                            
                            firstCount--;
                            matrix[row, col] = 'X';
                        }
                        else if (matrix[row, col] == '>')
                        {
                            firstPlayer++;
                            secondCount--;
                            matrix[row, col] = 'X';
                        }
                    }
                }
                else
                {
                    if (firstCount <= 0)
                    {
                        break;
                    }
                    else if (secondCount <= 0)
                    {
                        break;
                    }

                    if (IsPositionValid(row, col, n, n))
                    {
                        if (matrix[row, col] == '#')
                        {
                            matrix[row, col] = 'X';
                            if (IsPositionValid(row, col + 1, n, n))
                            {
                                if (matrix[row, col + 1] == '>')
                                {
                                    secondPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row, col + 1] == '<')
                                {
                                    firstCount--;
                                    secondPlayer++;
                                }
                                matrix[row, col + 1] = 'X';
                            }
                            if (IsPositionValid(row + 1, col, n, n))
                            {
                                if (matrix[row + 1, col] == '>')
                                {
                                    secondPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row + 1, col] == '<')
                                {
                                    firstCount--;
                                    secondPlayer++;
                                }
                                matrix[row + 1, col] = 'X';
                            }
                            if (IsPositionValid(row + 1, col + 1, n, n))
                            {
                                if (matrix[row + 1, col + 1] == '>')
                                {
                                    secondPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row + 1, col + 1] == '<')
                                {
                                    firstCount--;
                                    secondPlayer++;
                                }
                                matrix[row + 1, col + 1] = 'X';
                            }
                            if (IsPositionValid(row, col - 1, n, n))
                            {
                                if (matrix[row, col - 1] == '>')
                                {
                                    secondPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row, col - 1] == '<')
                                {
                                    firstCount--;
                                    secondPlayer++;
                                }
                                matrix[row, col - 1] = 'X';
                            }
                            if (IsPositionValid(row - 1, col + 1, n, n))
                            {
                                if (matrix[row - 1, col + 1] == '>')
                                {
                                    secondPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row -1, col + 1] == '<')
                                {
                                    firstCount--;
                                    secondPlayer++;
                                }
                                matrix[row - 1, col + 1] = 'X';
                            }
                            if (IsPositionValid(row - 1, col - 1, n, n))
                            {
                                if (matrix[row - 1, col - 1] == '>')
                                {
                                    secondPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row - 1, col - 1] == '<')
                                {
                                    firstCount--;
                                    secondPlayer++;
                                }
                                matrix[row - 1, col - 1] = 'X';
                            }
                            if (IsPositionValid(row + 1, col - 1, n, n))
                            {
                                if (matrix[row + 1, col - 1] == '>')
                                {
                                    secondPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row + 1, col - 1] == '<')
                                {
                                    firstCount--;
                                    secondPlayer++;
                                }
                                matrix[row + 1, col - 1] = 'X';
                            }
                            if (IsPositionValid(row - 1, col, n, n))
                            {
                                if (matrix[row - 1, col] == '>')
                                {
                                    secondPlayer++;
                                    secondCount--;
                                }
                                else if (matrix[row - 1, col] == '<')
                                {
                                    firstCount--;
                                    secondPlayer++;
                                }
                                matrix[row - 1, col] = 'X';
                            }
                        }
                        else if (matrix[row, col] == '<')
                        {
                            secondPlayer++;
                            firstCount--;
                            matrix[row, col] = 'X';
                        }
                        else if (matrix[row, col] == '>')
                        {
                            firstCount--;
                            matrix[row, col] = 'X';
                        }
                    }
                }
                


            }

            if (firstPlayer > secondPlayer)
            {
                Console.WriteLine($"Player One has won the game! {firstPlayer} ships have been sunk in the battle.");
            }
            else if (secondPlayer > firstPlayer)
            {
                Console.WriteLine($"Player Two has won the game! {secondPlayer} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {firstCount} ships left. Player Two has {secondCount} ships left.");
            }

           // Print(matrix);  


        }

        public static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }

        static void Print(char[,] matrix)
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
    }
}
