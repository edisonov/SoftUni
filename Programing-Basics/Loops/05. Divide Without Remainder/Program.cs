using System;
using System.Threading.Tasks.Dataflow;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int grup1 = 0;
            int grup2 = 0;
            int grup3 = 0;

            for (int number = 0; number < n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                // поверка за група1
                if (value % 2 == 0)
                {
                    grup1++;
                    //grup1 += 1;
                }
                // поверка за група2
                if (value % 3 == 0)
                {
                    grup2++;
                    //grup2 += 1;
                }
                // поверка за група3
                if (value % 4 == 0)
                {
                    grup3++;
                    //grup1 += 1;
                }
            }
            double pecent1 = grup1 * 1.0 / n * 100;
            double pecent2 = grup2 * 1.0 / n * 100;
            double pecent3 = grup3 * 1.0 / n * 100;

            Console.WriteLine($"{pecent1:f2}%");
            Console.WriteLine($"{pecent2:f2}%");
            Console.WriteLine($"{pecent3:f2}%");
        }
    }
}
