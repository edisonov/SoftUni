using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int fiarstLine = int.Parse(Console.ReadLine());
            int secondtLine = int.Parse(Console.ReadLine());

            for (int i = fiarstLine; i <= secondtLine; i++)
            {
                char index = (char)(i);
                Console.Write($"{index} ");
            }

        }
    }
}
