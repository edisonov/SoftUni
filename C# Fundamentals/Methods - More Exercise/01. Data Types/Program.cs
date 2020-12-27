using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string num = Console.ReadLine();
            IntNumber(input, num);
            DoubleNumber(input, num);
            StringNumber(input, num);
         
        }

        private static void StringNumber(string input, string num)
        {
            if (input == "string")
            {
                Console.WriteLine($"${num}$");
            }
        }

        private static void DoubleNumber(string input, string num)
        {
            if (input == "real")
            {
                double number = double.Parse(num);
                number *= 1.5;
                Console.WriteLine($"{number:f2}");
            }
        }

        static void IntNumber(string input, string num)
        {
            if (input == "int")
            {
                int number = int.Parse(num);
                number *= 2;
                Console.WriteLine(number);
            }
        }
    }
}
