using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopNumber(number);
        }

        private static void PrintTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                string currentNumber = i.ToString();
                bool isOddDigits = false;
                int sumOddDigits = 0;

                foreach (var curr in currentNumber)
                {
                    int parseNumber = (int)curr;

                    if (parseNumber % 2 == 1)
                    {
                        isOddDigits = true;
                    }

                    sumOddDigits += parseNumber;
                }

                if (sumOddDigits % 8 == 0 && isOddDigits)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
