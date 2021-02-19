using System;

namespace _02SpaceStationMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int stephenRow = 0;
            int stephenCol = 0;

            char[][] field = new char[size][];

            for (int row = 0; row < size; row++)
            {
                field[row] = new char[size];

                char[] cols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    char ch = cols[col];

                    if (ch == 'S')
                    {
                        stephenRow = row;
                        stephenCol = col;
                    }

                    field[row][col] = ch;
                }
            }

            int stars = 0;

            while (true)
            {
                field[stephenRow][stephenCol] = '-';

                string command = Console.ReadLine();

                switch (command)
                {
                    case "right":
                        stephenCol += 1;
                        break;
                    case "left":
                        stephenCol += 1;
                        break;
                    case "up":
                        stephenRow -= 1;
                        break;
                    case "down":
                        stephenRow += 1;
                        break;
                }

                if (IsOutsize(size, stephenRow, stephenCol))
                {
                    Console.WriteLine("Bed spaceship");
                    break;
                }

                char element = field[stephenRow][stephenCol];

                if (element == 'O')
                {
                    field[stephenRow][stephenCol] = '-';

                    for (int row = 0; row < size; row++)
                    {
                        bool faund = false;
                        for (int col = 0; col < size; col++)
                        {
                            char matrixElement = field[row][col];

                            if (matrixElement == 'O')
                            {
                                stephenRow = row;
                                stephenCol = col;

                                field[stephenRow][stephenCol] = 'S';

                                faund = true;
                                break;
                            }
                        }

                        if (faund)
                        {
                            break;
                        }
                    }
                }
                else if (char.IsDigit(element))
                {
                    stars += element - '0';

                    if (stars >= 50)
                    {
                        Console.WriteLine("good tou win");
                        break;
                    }
                }
            }

            Console.WriteLine($"Stars power {stars}");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(field[row][col]);
                }

                Console.WriteLine();
            }
        }

        private static bool IsOutsize(int size, int stephenRow, int stephenCol)
        {
            return stephenRow >= size ||
                stephenRow < 0 ||
                stephenCol >= size ||
                stephenCol < 0;
        }
    }
}
