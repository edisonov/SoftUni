using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int numbar = input;

            int currentNumbar = 0;
            int facturialSum = 0;

            while (numbar != 0)
            {
                currentNumbar = numbar % 10;
                numbar /= 10;
                int facturial = 1;

                for (int i = 1; i <= currentNumbar; i++)
                {
                    facturial *= i;
                }
                facturialSum += facturial;
            }
            string result = string.Empty;
            if (input == facturialSum)
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }
            Console.WriteLine(result);
        }
    }
}
