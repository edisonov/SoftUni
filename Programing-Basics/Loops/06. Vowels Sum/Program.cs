using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int sume = 0;
            int sumi = 0;
            int sumo = 0;
            int sumu = 0;
            string sum = Console.ReadLine().ToLower();
            for (int i = 0; i < sum.Length; i++)
            {
                if (sum[i] == 'a')
                    suma++;
                else if (sum[i] == 'e')
                    sume += 2;
                else if (sum[i] == 'i')
                    sumi += 3;
                else if (sum[i] == 'o')
                    sumo += 4;
                else if (sum[i] == 'u')
                    sumu += 5;
            }
            int ResultSum = suma + sume + sumi + sumo + sumu;
            Console.WriteLine(ResultSum);
        }
    }
}
