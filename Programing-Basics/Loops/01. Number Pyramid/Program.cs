using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 1;
            bool isBigger = false;

            for (int row = 1; row <= n; row++)
            {
                for (int cols = 1; cols <= row; cols++)
                {
                    if (counter > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(counter + " ");
                    counter++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
