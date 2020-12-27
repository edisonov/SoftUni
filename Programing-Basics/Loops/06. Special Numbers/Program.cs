using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int numbar = 1111; numbar <= 9999; numbar++)
            {
                int thousands = numbar / 1000;
                int hundreds = (numbar / 100) % 10;
                int tens = (numbar / 10) % 10;
                int units = numbar % 10;

                bool check1 = thousands != 0 && n % thousands == 0;
                bool check2 = hundreds != 0 && n % hundreds == 0;
                bool check3 = tens != 0 && n % tens == 0;
                bool check4 = units != 0 && n % units == 0;

                if (check1 && check2 && check3 && check4)
                {
                    Console.Write(numbar + " ");
                }
            }
        }
    }
}
