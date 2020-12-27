using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            PrintString(text, num);
        }

        private static void PrintString(string text, int num)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < num; i++)
            {
                result.Append(text);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
